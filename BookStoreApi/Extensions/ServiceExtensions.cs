using System.Reflection;
using BookapiMinimal.AppContext;
using BookapiMinimal.Exceptions;
using BookapiMinimal.Interfaces;
using BookapiMinimal.Services;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace BookapiMinimal.Extensions;

public static class ServiceExtensions
{
    public static void AddApplicationServices(this IHostApplicationBuilder builder)
    {
        if (builder == null)
            throw new ArgumentNullException(nameof(builder));

        if (builder.Configuration == null)
            throw new ArgumentNullException(nameof(builder.Configuration));

        // Adding the database context
        builder.Services.AddDbContext<ApplicationContext>(configure =>
        {
            configure.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
        });

        builder.Services.AddScoped<IBookService, BookService>();

        builder.Services.AddExceptionHandler<GlobalExceptionHandler>();

        builder.Services.AddProblemDetails();

        // Adding validators from the current assembly
        builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
