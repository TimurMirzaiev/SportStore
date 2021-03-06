﻿using Core.Interfaces.Services;
using Core.Services;
using Data.Context;
using Data.Entities;
using Data.Repositories;
using Infrastructure.Core.AutoMapper;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DependenciesResolver
{
    public static class ServiceCollectionExtensions
    {

        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            string connection = configuration["Data:SportStoreProducts:ConnectionString"];

            services.AddSingleton<Infrastructure.Interfaces.IMapper, SportStoreAutoMapper>();

            services.AddTransient<IRepository<Product>, ProductRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderService, OrderService>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connection));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
            });

            services.AddSingleton<IIdentityInitializer, IdentityInitializer>();
        }
    }
}
