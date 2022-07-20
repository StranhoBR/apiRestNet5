using ApiAppNet5.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAppNet5.Data
{
    public class ApiAppNet5Context : DbContext
    {
        public ApiAppNet5Context(DbContextOptions<ApiAppNet5Context> opt) : base(opt)
        {

        }

        public DbSet<ApiAppNet5.Models.ApiAppNet5> ApiAppNet5 { get; set; }

    }
}