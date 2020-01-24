using System;
using System.Collections.Generic;
using System.Text;

namespace GustavLindblom.Domain.Entities
{
    public class Post : TimestampedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Abstract { get; set; }
        public string Content { get; set; }
        
        public IEnumerable<Category> Categories { get; set; }
    }
}
