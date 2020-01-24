using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using GustavLindblom.Common.ExtensionLibrary.Extensions;

namespace GustavLindblom.Infrastructure.DependencyInjection.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void InvokeAllServiceConfigurators(this IServiceCollection serviceCollection)
        {
            GetAllServiceConfigurators()
                .ForEach(serviceConfigurator => serviceConfigurator.ConfigureServices(serviceCollection));
        }

        private static IEnumerable<IServiceConfigurator> GetAllServiceConfigurators()
        {
            var assemblies = Directory
                .GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll")
                .Select(file => AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(file)));

            var types = assemblies
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => typeof(IServiceConfigurator).IsAssignableFrom(type) && !type.IsAbstract && !type.IsInterface);

            return types.Select(type => (IServiceConfigurator) Activator.CreateInstance(type));
        }
    }
}
