using System;
using Microsoft.Extensions.DependencyInjection;

namespace GustavLindblom.Infrastructure.DependencyInjection
{
    public interface IServiceConfigurator
    {
        void ConfigureServices(IServiceCollection serviceCollection);
    }
}
