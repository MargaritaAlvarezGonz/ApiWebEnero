using APIServiceM.IServices;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

namespace APIServiceM.Services
{
    public class PersonService : IPersonService

    {
        private readonly IPersonLogic _personLogic;
        public PersonService(IPersonLogic personLogic)
        {
            _personLogic = personLogic;
        }
        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
            //_personLogic.DeletePerson(id);
        }

        public void DeletePersonItem(int id)
        {
            //throw new NotImplementedException();
            _personLogic.DeletePerson(id);
        }

        public List<PersonItem> GetAllPersons()
        {
            throw new NotImplementedException();
        }

        public List<PersonItem> GetPerson()
        {
            throw new NotImplementedException();
        }

        public int InsertPerson(PersonItem personItem)
        {
            _personLogic.InsertPerson(personItem);
            return personItem.Id;
        }

        public void UpdatePerson(PersonItem personItem)
        {
            throw new NotImplementedException();
        }
    }
}
