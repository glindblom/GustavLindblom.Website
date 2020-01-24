using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GustavLindblom.Application.Blog.Models;
using GustavLindblom.Domain.Entities;
using GustavLindblom.Domain.Interfaces;
using Microsoft.AspNetCore.Html;

namespace GustavLindblom.Application.Blog.Repositories
{
    class PostRepository : IPostRepository
    {

        private readonly Random _random = new Random(DateTime.Now.Millisecond);
        private readonly IApplicationDbContext _context;

        public PostRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PostViewModel>> GetAllAsync()
        {
            return await Task.FromResult(new List<PostViewModel>()
            {
                new PostViewModel() { Title = "Post 1", Description = "Lorem Ipsum Numbero Uno", PostId = "post-one", Categories = TestCategories(), Created = DateTime.Now},
                new PostViewModel() { Title = "Post 2", Description = "Lorem Ipsum Numbero Dos", PostId = "post-two",  Categories = TestCategories(), Created = DateTime.Now},
                new PostViewModel() { Title = "Post 3", Description = "Lorem Ipsum Numbero Tres", PostId = "post-three",  Categories = TestCategories(), Created = DateTime.Now},
                new PostViewModel() { Title = "Post 4", Description = "Lorem Ipsum Numbero Quatro", PostId = "post-four",  Categories = TestCategories(), Created = DateTime.Now}
            });
        }

        public async Task<PostViewModel> GetPinnedAsync()
        {
            var post = await Task.FromResult(_random.Next(10) > 5 ? new PostViewModel() { Title = "Pinned post", Description = "Lorem ipsum pinned post", PostId = "pinned-post",  Categories = TestCategories(), Created = DateTime.Now } : null);
            return post;
        }

        public async Task<PostDetailViewModel> GetAsync(string id)
        {
            return await Task.FromResult(id == "pinned-post" ? new PostDetailViewModel() { Title = "Pinned post", Abstract = "Pinned post", Content = new HtmlString("<p>This</p><p>is</p><p>pinned</p>")} : new PostDetailViewModel() {});
        }

        public async Task<string> CreateAsync(PostDetailViewModel post)
        {
            var entity = new Post()
            {
                Name = post.Title.Replace(" ", "_"),
                Title = post.Title,
                Abstract = post.Abstract,
                Description = post.Abstract,
                Content = post.Content.ToString()
            };

            await _context.Posts.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Name;
        }

        private IEnumerable<CategoryViewModel> TestCategories()
        {
            return new List<CategoryViewModel>()
            {
                new CategoryViewModel() { DisplayText = "C#", CssClass = "csharp" },
                new CategoryViewModel() { DisplayText = "Sitecore", CssClass = "sitecore" },
                new CategoryViewModel() { DisplayText = ".Net", CssClass = "net" }
            };
        }
    }
}
