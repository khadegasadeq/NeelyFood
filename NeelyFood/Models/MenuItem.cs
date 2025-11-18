namespace NeelyFood.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } // اختياري
        public string ImagePath { get; set; }
        public bool IsAvailable { get; set; }
        public int Quantity { get; set; } // الكمية المتوفرة اليوم

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
