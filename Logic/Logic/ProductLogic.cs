using Data;
using Entities.Entities;
using Entities.SearchFilters;
using Logic.ILogic;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ProductLogic : BaseContextLogic, IProductLogic
    {
        public ProductLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertProductItem(ProductItem productItem)
        {
            _serviceContext.Products.Add(productItem);
            _serviceContext.SaveChanges();
        }

        public List<ProductItem> GetProduct()
        {
            //return _serviceContext.Set<ProductItem>();ToList();
            var resultList = new List<ProductItem>();
            return resultList;
        }


        //public List <ProductItem> GetProducts()
        //{
        //    //FUNCIONAMIENTO DEL MÈTODO
        //    return _serviceContext.Set<ProductItem>().ToList();
        //    //var selectedItem = _serviceContext.Set<ProductItem>().Where(i => i.IsActive).ToList(); (ESTO FILTRA)

        //    //TRAE AL PRIMERO
        //    //var firstItem = _serviceContext.Set<ProductItem>().First();
        //    //firstItem = "kdkdkdkdkd";

        //    //LO MODIFICA
        //    _serviceContext.SaveChanges();
        //}

        public List<ProductItem> GetProductsByCriteria(ProductFilter productFilter)
        {
            return _serviceContext.Set<ProductItem>()
                .Where(p => p.IsActive == productFilter.IsActive)
                .ToList();
        }

        public List<ProductItem> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public void DeleteProductItem(int id)
        {
            var productToDelete = _serviceContext.Set<ProductItem>()
                .Where(x => x.Id == id);
            _serviceContext.SaveChanges();
        }

        public void UpdateProduct(ProductItem productItem)
        {
            _serviceContext.Products.Update(productItem);

            _serviceContext.SaveChanges();
        }
    }

}