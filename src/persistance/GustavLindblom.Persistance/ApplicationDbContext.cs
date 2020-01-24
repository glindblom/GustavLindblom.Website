using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using GustavLindblom.Common.ExtensionLibrary.Extensions;
using GustavLindblom.Domain.Entities;
using GustavLindblom.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GustavLindblom.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        
        public async Task<int> SaveChangesAsync()
        {
            var entries = ChangeTracker.Entries<TimestampedEntity>();
            entries.ForEach(entry =>
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.Updated = DateTime.Now;
                        break;
                    default:
                        break;
                }
            });

            return await base.SaveChangesAsync();
        }
    }
}
