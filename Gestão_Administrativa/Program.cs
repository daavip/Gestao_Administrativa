using Gestao_Administrativa.Domain.Interface;
using Gestao_Administrativa.Domain.Interface.Service;
using Gestao_Administrativa.Repository.Data;
using Gestao_Administrativa.Service;
using Microsoft.EntityFrameworkCore;

namespace Gestao_Administrativa
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
            builder.Services.AddScoped<IAddressService, AddressService>();
            builder.Services.AddScoped<IContactService, ContactService>();
            builder.Services.AddScoped<IContractService, ContractService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IStatusContractService, StatusContractService>();
            builder.Services.AddScoped<ISubscriptionService, SubscriptionService>();
            builder.Services.AddScoped<ISubscriptionTypeService, SubscriptionTypeService>();

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
