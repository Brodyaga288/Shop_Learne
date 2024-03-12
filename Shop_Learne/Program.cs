using Microsoft.EntityFrameworkCore;
using Shop_Learne.DAL;
namespace Shop_Learne
{
    /// <summary>
    /// ���������� �������. 2 ��������: ������, ��������� �������. �������� rest API:
    /// 1. � ������������ CRUD ��� ������ ��������.
    /// 2. � ������������ �������� ������ ������� � ���������, ���������� � �����������.
    /// 3. � ������ ����� ���� ��������.
    /// ����������� ����������� ���������/�������� �������� ������� �������. �������� ��������� �� ����. � �� ������ ������ ������ �� ��.���������� ���� ������.
    /// 4. ������������� ��� � ������ ��������� �� ����� 10(������������� ����������) ������ ������.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            string stringConnection = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseNpgsql(stringConnection));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
