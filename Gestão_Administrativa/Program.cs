
using Gestão_Administrativa.Data;
using Gestão_Administrativa.Repositories;
using Gestão_Administrativa.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Gestão_Administrativa
{
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

            builder.Services.AddDbContext<SubscriptionManagementDBContext>(
                options => options.UseNpgsql(builder.Configuration.GetConnectionString("DataBase"))
            );


            builder.Services.AddScoped<IUserRepo, UserRepo>();


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
