using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using dayFourRestAPIdayFiveDI.Services;

var builder = WebApplication.CreateBuilder(args);

// ����������� �������� � ���������� ������������
builder.Services.AddScoped<IProductService, ProductService>();

// ��������� �������� ���� ������
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=products.db").EnableSensitiveDataLogging());

// ��������� �����������
builder.Services.AddControllers();

// ��������� Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Products API", Version = "v1" });
});

var app = builder.Build();

// �������� Swagger � development-������
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Products API v1"));
}

app.UseAuthorization();
app.MapControllers();

app.Run();