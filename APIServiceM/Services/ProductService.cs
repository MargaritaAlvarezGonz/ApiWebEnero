using APIServiceM.IServices;
using Entities.Entities;
using Entities.SearchFilters;
using Logic.ILogic;

namespace APIServiceM.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

              
        public List<ProductItem> GetProduct() 
        {
            return _productLogic.GetProduct();
        }

        public List<ProductItem> GetProductsByCriteria(ProductFilter productFilter)
        {
            return _productLogic.GetProductsByCriteria(productFilter);
        }

        public void DeleteProductItem(int id)
        {
            _productLogic.DeleteProductItem(id);
        }

        public int InsertProduct(ProductItem productItem)
        {
            _productLogic.InsertProductItem(productItem);
            return productItem.Id;
        }

        public void UpdateProduct(ProductItem productItem)
        {
            _productLogic.UpdateProduct(productItem);
        }
    }
}

