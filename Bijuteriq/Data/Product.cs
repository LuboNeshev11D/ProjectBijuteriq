using System.ComponentModel;

namespace Bijuteriq.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }//F.K M:1
        public Category Categories { get; set; }//M:1
        public string Description { get; set; }

        public string PhotoURL { get; set; }
        public decimal Price { get; set; }
        public DateTime RegDate{get;set;}
        public ICollection<Order> Orders { get; set; }//1:M
    
    }
}
