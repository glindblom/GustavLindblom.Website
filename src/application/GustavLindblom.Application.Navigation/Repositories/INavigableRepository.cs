﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GustavLindblom.Application.Navigation.Models;

namespace GustavLindblom.Application.Navigation.Repositories
{
    interface INavigableRepository
    {
        Task<IEnumerable<Navigable>> GetNavigablesAsync();
    }
}
