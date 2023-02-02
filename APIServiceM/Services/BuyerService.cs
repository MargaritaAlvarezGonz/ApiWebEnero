using APIServiceM.IServices;
using Entities.Entities;
using Entities.RequestModels;
using Logic.ILogic;
using Logic.Logic;

namespace APIServiceM.Services
{
    public class BuyerService : IBuyerService
    {
        public void DeleteBuyer(int id)
        {
            throw new NotImplementedException();
            //_buyerLogic.DeleteBuyerItem(id);
        }

        public List<BuyerItem> GetAllBuyers()
        {
            throw new NotImplementedException();
            //return _buyerLogic.GetAllBuyers();
        }

        public int InserBuyer(NewUserRequest newUserRequest)
        {
            throw new NotImplementedException();
        }

        public int InsertBuyerItem(BuyerItem buyerItem)
        {
            throw new NotImplementedException();
            //_buyerLogic.InsertBuyerItem(buyerItem);
            //return buyerItem.Id;
        }

        public void UpdateBuyer(BuyerItem buyerItem)
        {
            throw new NotImplementedException();
            //_buyerLogic.UpdateBuyer(buyerItem);
        }
    }

        
    
}
