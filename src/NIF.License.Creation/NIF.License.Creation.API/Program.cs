
namespace NIF.License.API
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
            builder.Services.AddSwaggerGen(
               c =>
               {
                   c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                   {
                       Title = "License APIs",
                       Description = "All the APIs for the License Service",
                   });
                   var filePath = Path.Combine(AppContext.BaseDirectory, "NIF.License.Creation.API.xml");
                   c.IncludeXmlComments(filePath);
               });
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}