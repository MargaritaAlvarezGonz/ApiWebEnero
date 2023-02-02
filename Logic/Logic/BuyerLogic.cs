using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class BuyerLogic : IBuyerLogic
    {
        public readonly ServiceContext _serviceContext;
        public void DeleteBuyer(int id)
        {
            var buyerToDelete = _serviceContext.Set<BuyerItem>()
                .Where(item => item.Id == id).First();
                 _serviceContext.SaveChanges();
        }

        public List<BuyerItem> GetAllBuyers()
        {
            var resultList = new List<BuyerItem>();
            return resultList;

        }

       

        public int InsertBuyerItem(BuyerItem buyerItem)
        {
            if (buyerItem.IdRol == 2)
            {
                throw new InvalidOperationException();
            };

            _serviceContext.Buyers.Add(buyerItem);
            _serviceContext.SaveChanges();
            return buyerItem.Id; ;
        }

        public void UpdateBuyer(BuyerItem buyerItem)
        {
            _serviceContext.Buyers.Update(buyerItem);

            _serviceContext.SaveChanges();
        }
    }
}
