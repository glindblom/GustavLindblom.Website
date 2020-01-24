using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GustavLindblom.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GustavLindblom.Domain.Interfaces
{
    public interface IApplicationDbContext
    {

        DbSet<Page> Pages { get; set; }
        DbSet<Post> Posts { get; set; }

        Task<int> SaveChangesAsync();
    }
}
