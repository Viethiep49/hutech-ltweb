using Microsoft.EntityFrameworkCore;
using BookWebAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Cấu hình phục vụ file tĩnh từ thư mục Content/ImageBooks
var contentPath = Path.Combine(builder.Environment.ContentRootPath, "Content", "ImageBooks");
if (!Directory.Exists(contentPath))
{
    Directory.CreateDirectory(contentPath);
}

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new Microsoft.Extensions.FileProviders.PhysicalFileProvider(contentPath),
    RequestPath = "/Content/ImageBooks"
});

app.UseAuthorization();

app.MapControllers();

app.Run();
