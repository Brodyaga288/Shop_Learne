using Microsoft.EntityFrameworkCore;
using Shop_Learne.DAL;
namespace Shop_Learne
{
    /// <summary>
    /// Приложение магазин. 2 сущности: товары, категории товаров. Написать rest API:
    /// 1. С возможностью CRUD для каждой сущности.
    /// 2. С возможностью получать список товаров с фильтрами, пагинацией и сортировкой.
    /// 3. У товара может быть картинка.
    /// Реализовать возможность сохранить/получить картинку разного размера. Картинку сохраняем на диск. В бд храним только ссылку на неё.Возвращаем тоже ссылку.
    /// 4. Предусмотреть что в каждой категории не более 10(настраиваемое количество) единиц товара.
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
