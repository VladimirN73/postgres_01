using Microsoft.EntityFrameworkCore;

namespace App.WebApi;

public class Program
{
    

    public static void Main(string[] args)
    {
        string corsPolicyName = "CustomRequestOriginPolicy";

        var builder = WebApplication.CreateBuilder(args);

        var services = builder.Services;

        // Add services to the container.

        services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddCors(options =>
        {
            options.AddPolicy(corsPolicyName, policyBuilder =>
            {
                policyBuilder.AllowAnyOrigin();
                policyBuilder.AllowAnyHeader();
                policyBuilder.AllowAnyMethod();
            });
        });


        var connectionString = builder.Configuration.GetConnectionString("db") ?? string.Empty;
        Console.WriteLine($"connectionString: '{connectionString}'");
        builder.Services
            .AddEntityFrameworkNpgsql()
            .AddDbContext<ApiDbContext>(opt => opt.UseNpgsql(connectionString));
        
        var app = builder.Build();

        Console.WriteLine($"app.Environment.IsDevelopment()='{app.Environment.IsDevelopment()}'");
        Console.WriteLine($"app.Environment='{app.Environment}'");

        //if (app.Environment.IsDevelopment())
        //{
        //    app.UseSwagger();
        //    app.UseSwaggerUI();
        //}
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseCors(corsPolicyName); //https://learn.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-7.0

        app.UseHttpsRedirection();

        app.UseAuthorization();
        app.MapControllers();

        // Update Database in runtime
        // https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/applying?tabs=dotnet-core-cli
        //
        using (var scope = app.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<ApiDbContext>();
            db.Database.Migrate();
        }

        app.Run();
    }
}
