using Entities.Entities;

namespace APIServiceM.IServices
{
    public interface IPersonService
    {
        int InsertPerson(PersonItem personItem);
        void UpdatePerson(PersonItem personItem);
        void DeletePerson(int id);
        List<PersonItem> GetAllPersons();
        List<PersonItem> GetPerson();
        void DeletePersonItem(int id);
    }
}
