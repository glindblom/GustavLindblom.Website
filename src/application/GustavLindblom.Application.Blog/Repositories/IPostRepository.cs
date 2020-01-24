using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GustavLindblom.Application.Blog.Models;
using GustavLindblom.Domain.Entities;

namespace GustavLindblom.Application.Blog.Repositories
{
    public interface IPostRepository
    {
        Task<IEnumerable<PostViewModel>> GetAllAsync();
        Task<PostViewModel> GetPinnedAsync();
        Task<PostDetailViewModel> GetAsync(string id);
        Task<string> CreateAsync(PostDetailViewModel post);
    }
}
