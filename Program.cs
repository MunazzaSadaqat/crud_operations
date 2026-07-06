using crud_operations.Data;
using Microsoft.EntityFrameworkCore;

namespace crud_operations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<myContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("myconnection")));
            builder.Services.AddMvc();
            var app = builder.Build();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=First}/{action=Index}"
                );

            app.Run();
        }
    }
}
