using System;
using System.Collections.Generic;
using System.Text;

namespace GustavLindblom.Application.Navigation.Models
{
    public class NavigationViewModel
    {
        public string Heading { get; set; }
        public string Tagline { get; set; }
        public IEnumerable<Navigable> Navigables { get; set; }
     }
}
