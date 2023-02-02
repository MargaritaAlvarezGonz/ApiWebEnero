using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IBuyerLogic
    {
        int InsertBuyerItem(BuyerItem buyerItem);
        void UpdateBuyer(BuyerItem buyerItem);
        void DeleteBuyer(int id);
        List<BuyerItem> GetAllBuyers();
    }
}
