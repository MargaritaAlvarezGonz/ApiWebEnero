using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IPersonLogic
    {
        int InsertPerson(PersonItem personItem);
        void UpdatePerson(PersonItem personItem);

        void DeletePerson(int id);
    }
}
