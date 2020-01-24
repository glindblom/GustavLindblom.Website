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
        Task<IEnumerable<PostViewModel>> GetAll();
        Task<PostViewModel> GetPinned();
        Task<PostDetailViewModel> Get(string id);
        Task<string> Create(PostDetailViewModel post);
    }
}
