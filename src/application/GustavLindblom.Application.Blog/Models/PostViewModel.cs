using System;
using System.Collections.Generic;
using System.Text;

namespace GustavLindblom.Application.Blog.Models
{
    public class PostViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public string PostId { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
