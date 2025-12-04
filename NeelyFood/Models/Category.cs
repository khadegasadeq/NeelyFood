using System.Collections.Generic;

namespace NeelyFood.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; } // صورة القسم

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
