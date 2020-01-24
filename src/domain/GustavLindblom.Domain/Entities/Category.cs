using System;
using System.Collections.Generic;
using System.Text;

namespace GustavLindblom.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string DisplayText { get; set; }
        public string CssClass { get; set; }
    }
}