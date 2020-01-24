using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GustavLindblom.Application.Blog.Models;
using GustavLindblom.Application.Blog.Repositories;

namespace GustavLindblom.Application.Blog.Services
{
    class BlogService : IBlogService
    {

        private readonly IPostRepository _postRepository;

        public BlogService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<BlogViewModel> GetBlogViewModel()
        {
            var posts = await _postRepository.GetAll();
            var pinnedPost = await _postRepository.GetPinned();

            return new BlogViewModel()
            {
                PostDetailBaseUrl = "/post/",
                PinnedPost = pinnedPost,
                Posts = posts
            };
        }

        public Task<PostDetailViewModel> GetPostDetailViewModel()
        {
            throw new NotImplementedException();
        }

        public Task<string> CreatePost(PostDetailViewModel postDetail)
        {
            throw new NotImplementedException();
        }
    }
}
