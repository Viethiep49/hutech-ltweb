using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Web_API
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private readonly HttpClient _client;
        private string _selectedImagePath = "";
        private int _selectedBookId = 0;
        private const string API_URL = "http://localhost:9999/api/BookAPI";

        public Form1()
        {
            InitializeComponent();
            _client = new HttpClient();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadBooks();
        }

        private async Task LoadBooks(string search = "")
        {
            try
            {
                string url = API_URL;
                if (!string.IsNullOrEmpty(search))
                {
                    url += "?search=" + Uri.EscapeDataString(search);
                }

                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    List<Book> books = js.Deserialize<List<Book>>(json);
                    
                    dgvBooks.DataSource = null;
                    dgvBooks.DataSource = books;
                }
                else
                {
                    MessageBox.Show("Failed to load books: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadBooks(txtSearch.Text.Trim());
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var content = new MultipartFormDataContent())
                {
                    content.Add(new StringContent(txtTitle.Text), "Title");
                    content.Add(new StringContent(txtAuthor.Text), "Author");
                    content.Add(new StringContent(txtCategoryId.Text), "CategoryId");

                    if (!string.IsNullOrEmpty(_selectedImagePath))
                    {
                        byte[] imageBytes = File.ReadAllBytes(_selectedImagePath);
                        var imageContent = new ByteArrayContent(imageBytes);
                        imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
                        content.Add(imageContent, "imageFile", Path.GetFileName(_selectedImagePath));
                    }

                    HttpResponseMessage response = await _client.PostAsync(API_URL, content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Book added successfully!");
                        ClearForm();
                        await LoadBooks();
                    }
                    else
                    {
                        MessageBox.Show("Error adding: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedBookId == 0)
            {
                MessageBox.Show("Please select a book to edit first.");
                return;
            }

            try
            {
                using (var content = new MultipartFormDataContent())
                {
                    content.Add(new StringContent(_selectedBookId.ToString()), "Id");
                    content.Add(new StringContent(txtTitle.Text), "Title");
                    content.Add(new StringContent(txtAuthor.Text), "Author");
                    content.Add(new StringContent(txtCategoryId.Text), "CategoryId");

                    if (!string.IsNullOrEmpty(_selectedImagePath))
                    {
                        byte[] imageBytes = File.ReadAllBytes(_selectedImagePath);
                        var imageContent = new ByteArrayContent(imageBytes);
                        imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
                        content.Add(imageContent, "imageFile", Path.GetFileName(_selectedImagePath));
                    }

                    HttpResponseMessage response = await _client.PutAsync(API_URL + "/" + _selectedBookId, content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Book updated successfully!");
                        ClearForm();
                        await LoadBooks();
                    }
                    else
                    {
                        MessageBox.Show("Error updating: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedBookId == 0)
            {
                MessageBox.Show("Please select a book to delete first.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this book?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    HttpResponseMessage response = await _client.DeleteAsync(API_URL + "/" + _selectedBookId);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Book deleted successfully!");
                        ClearForm();
                        await LoadBooks();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = ofd.FileName;
                    pbImage.ImageLocation = _selectedImagePath;
                }
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvBooks.Rows.Count)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];
                if (row.Cells["Id"].Value != null)
                {
                    _selectedBookId = Convert.ToInt32(row.Cells["Id"].Value);
                    txtTitle.Text = row.Cells["Title"].Value?.ToString();
                    txtAuthor.Text = row.Cells["Author"].Value?.ToString();
                    txtCategoryId.Text = row.Cells["CategoryId"].Value?.ToString();
                    
                    string imagePath = row.Cells["Image"].Value?.ToString();
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        pbImage.ImageLocation = "http://localhost:9999" + imagePath;
                    }
                    else
                    {
                        pbImage.ImageLocation = null;
                        pbImage.Image = null;
                    }

                    _selectedImagePath = ""; // Reset selected path when browsing grid
                }
            }
        }

        private void ClearForm()
        {
            _selectedBookId = 0;
            _selectedImagePath = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtCategoryId.Text = "";
            txtSearch.Text = "";
            pbImage.ImageLocation = null;
            pbImage.Image = null;
        }
    }

}
