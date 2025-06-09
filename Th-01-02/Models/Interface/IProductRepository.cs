namespace Th_01_02.Models
{
    public interface IProductRepository
    {

        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetTrendingProducts();
        Product GetProductDetail(int id);
    }
}
