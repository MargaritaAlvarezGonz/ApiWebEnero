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
    public class PersonLogic : IPersonLogic
    {
        private readonly ServiceContext _serviceContext;
        public PersonLogic(ServiceContext serviceContext)
       
        {
            _serviceContext = serviceContext;
        }

        public void DeletePerson(int id)
        {
            //throw new NotImplementedException();
            var personToDelete = _serviceContext.Set<PersonItem>()
                .Where(x => x.Id == id);
               
        }

        public int InsertPerson(PersonItem personItem)
        {
            _serviceContext.Persons.Add(personItem);
            _serviceContext.SaveChanges();
            return personItem.Id;
        }

        public void UpdatePerson(PersonItem personItem)
        {
            throw new NotImplementedException();
        }
    }
}
