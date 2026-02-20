namespace e_commerce_api.Source.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
   }
}