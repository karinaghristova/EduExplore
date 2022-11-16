﻿using EduExplore.Infrastructure.Data;
using EduExplore.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicationDbRepository, ApplicationDbRepository>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IMovieService, MovieService>();
            //services.AddScoped<IBookService, BookService>();
            //services.AddScoped<IExerciseService, ExerciseService>();
            //services.AddScoped<IWorkoutService, WorkoutService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContexts(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
    }
}