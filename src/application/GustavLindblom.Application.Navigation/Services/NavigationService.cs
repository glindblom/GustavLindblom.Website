using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GustavLindblom.Application.Navigation.Models;
using GustavLindblom.Application.Navigation.Repositories;

namespace GustavLindblom.Application.Navigation.Services
{
    class NavigationService : INavigationService
    {

        private readonly INavigableRepository _navigableRepository;

        public NavigationService(INavigableRepository navigableRepository)
        {
            _navigableRepository = navigableRepository;
        }

        public async Task<NavigationViewModel> GetNavigation()
        {
            var navigables = await _navigableRepository.GetNavigables();

            return new NavigationViewModel()
            {
                Heading = "Gustav Lindblom",
                Tagline = "...",
                Navigables = navigables
            };
        }
    }
}
