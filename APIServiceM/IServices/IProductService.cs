using Entities.Entities;
using Entities.SearchFilters;

namespace APIServiceM.IServices
{
    public interface IProductService
    {
        int InsertProduct(ProductItem productItem);
        List<ProductItem> GetProduct(); //tengo declaarado que este mètodo "getProduct" sin parámetros me va a dar una lista de ProductItem. Esta clase aquí está funcionando como un tipo de datos
        

        List<ProductItem> GetProductsByCriteria(ProductFilter productFilter);
        void DeleteProductItem(int id);

        void UpdateProduct(ProductItem productItem);

        //List<ProductItem> GetAllProducts();

    }
}
