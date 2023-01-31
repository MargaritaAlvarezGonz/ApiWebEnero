using Entities.Entities;
using Entities.SearchFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logic.ILogic
{
    public interface IProductLogic
    {
        void InsertProductItem(ProductItem productitem);
        List<ProductItem> GetAllProduct();

        List<ProductItem> GetProductsByCriteria(ProductFilter productFilter);
        List<ProductItem> GetProduct();

        void DelProductItem(ProductItem productitem);
        void DeleteProductItem(int id);
    }
}
