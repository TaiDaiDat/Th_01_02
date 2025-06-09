using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Th_01_02.Models
{
    public class CoffeeshopDbContextFactory : IDesignTimeDbContextFactory<CoffeeshopDbContext>
    {
        public CoffeeshopDbContext CreateDbContext(string[] args)
        {
            // Xác định thư mục gốc (cùng với file appsettings.json)
            var basePath = Directory.GetCurrentDirectory();

            // Đọc cấu hình từ appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();

            // Lấy connection string
            var connectionString = configuration.GetConnectionString("CoffeeShopDbContextConnection");

            var optionsBuilder = new DbContextOptionsBuilder<CoffeeshopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CoffeeshopDbContext(optionsBuilder.Options);
        }
    }
}
