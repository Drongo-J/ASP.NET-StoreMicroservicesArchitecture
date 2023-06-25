using ProductService.Entities;

namespace ProductService.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void AddProduct(Product product);
        void DecreaseQuantity(int productId, int quantity);
        void Update(Product product);
    }
}
