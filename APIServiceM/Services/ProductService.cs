using APIServiceM.IServices;
using Entities.Entities;
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

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductItem> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public int InsertProduct(ProductItem productItem)
        {
            _productLogic.InsertProductItem(productItem);
            return productItem.Id;
        }

        public void UpdateProduct(ProductItem productItem)
        {
            throw new NotImplementedException();
        }
    }
}

