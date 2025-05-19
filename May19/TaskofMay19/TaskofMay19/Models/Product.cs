using System.ComponentModel;

namespace TaskofMay19.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

       // public Category Category { get; set; }    // Navigation Property

    }

   // public class Category
    //{
      //  public int CategoryId { get; set; }

        //public string CategoryName { get; set; }

        //public ICollection<Product> Products { get; set; }  // Navigation Property 

    //}
}

