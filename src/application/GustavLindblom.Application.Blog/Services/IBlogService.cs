using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GustavLindblom.Application.Blog.Models;

namespace GustavLindblom.Application.Blog.Services
{
    public interface IBlogService
    {
        Task<BlogViewModel> GetBlogViewModel();
        Task<PostDetailViewModel> GetPostDetailViewModel();
        Task<string> CreatePost(PostDetailViewModel postDetail);
    }
}
