using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GustavLindblom.Application.Navigation.Models;

namespace GustavLindblom.Application.Navigation.Services
{
    public interface INavigationService
    {
        Task<NavigationViewModel> GetNavigation();
    }
}
