using System;
using System.Collections.Generic;
using System.Text;

namespace GustavLindblom.Application.Blog.Models
{
    public class BlogViewModel
    {
        public PostViewModel PinnedPost { get; set; }
        public IEnumerable<PostViewModel> Posts { get; set; }

        public string PostDetailBaseUrl { get; set; }
    }
}
