using Entities.Entities;

namespace APIServiceM.IServices
{
    public interface IProductService
    {
        int InsertProduct(ProductItem productItem);
        void UpdateProduct(ProductItem productItem);
        void DeleteProduct(int id);
        List<ProductItem> GetAllProducts();
        
    }
}
