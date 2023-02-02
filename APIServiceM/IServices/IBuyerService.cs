using Entities.Entities;
using Entities.RequestModels;

namespace APIServiceM.IServices
{
    public interface IBuyerService
    {
        int InserBuyer(NewUserRequest newUserRequest);
        void UpdateBuyer(BuyerItem buyerItem);
        void DeleteBuyer(int id);
        List<BuyerItem> GetAllBuyers();
    }
}
