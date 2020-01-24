using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GustavLindblom.Application.Blog.Models;
using GustavLindblom.Application.Blog.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GustavLindblom.Presentation.WebApplication
{
    public class PostModel : PageModel
    {

        private readonly IPostRepository _postRepository;

        public PostModel(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public PostDetailViewModel PostDetailViewModel { get; set; }

        public async Task OnGet(string postId)
        {
            PostDetailViewModel = await _postRepository.GetPost(postId);
        }
    }
}