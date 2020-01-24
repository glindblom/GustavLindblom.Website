using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Html;

namespace GustavLindblom.Application.Blog.Models
{
    public class PostDetailViewModel
    {
        public string Title { get; set; }
        public string Abstract { get; set; }
        public IHtmlContent Content { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
