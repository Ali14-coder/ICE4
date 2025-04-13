
using Microsoft.EntityFrameworkCore;
using WhiskAwayAPI.Model;

namespace WhiskAwayAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            
            app.UseSwagger();
            app.UseSwaggerUI();
            

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapGet("/products", async (ApplicationDbConnect context) =>
                await context.Products.ToListAsync());

            app.MapGet("/products/{id}", async (ApplicationDbConnect context, int id) =>
                await context.Products.FindAsync(id) is Product product
                    ? Results.Ok(product)
                    : Results.NotFound());

            app.MapGet("/Test", (HttpContext httpContext) =>
            {
                return "I am a docker King 2025 is my year :) ";
            })
            .WithName("GetHello")
            .WithOpenApi();


            app.Run();
        }
    }
}
