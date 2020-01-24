using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GustavLindblom.Application.Navigation.Models;

namespace GustavLindblom.Application.Navigation.Repositories
{
    class NavigableRepository : INavigableRepository
    {
        public async Task<IEnumerable<Navigable>> GetNavigablesAsync()
        {
            var navigables = await Task.FromResult(new List<Navigable>()
            {
                new Navigable() { DisplayText = "Home", Page = "/" },
                new Navigable() { DisplayText = "About", Page = "/about"},
                new Navigable() { DisplayText = "Contact", Page = "/contact" }
            });

            return navigables;
        }
    }
}
