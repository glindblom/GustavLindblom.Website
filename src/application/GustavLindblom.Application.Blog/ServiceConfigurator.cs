using System;
using GustavLindblom.Application.Blog.Repositories;
using GustavLindblom.Application.Blog.Services;
using GustavLindblom.Infrastructure.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace GustavLindblom.Application.Blog
{
    public class ServiceConfigurator : IServiceConfigurator
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IPostRepository, PostRepository>();
            serviceCollection.AddTransient<IBlogService, BlogService>();
        }
    }
}
