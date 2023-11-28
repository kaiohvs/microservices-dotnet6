namespace GeekShopping.ProductAPI.Data.Dto.Response
{
    public class ProductResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string CatagoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
