using System;
using GustavLindblom.Application.Navigation.Repositories;
using GustavLindblom.Application.Navigation.Services;
using GustavLindblom.Infrastructure.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace GustavLindblom.Application.Navigation
{
    public class ServiceConfigurator : IServiceConfigurator
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<INavigableRepository, NavigableRepository>();
            serviceCollection.AddTransient(typeof(INavigationService),
                p => new NavigationService((INavigableRepository)p.GetService(typeof(INavigableRepository))));
        }
    }
}
