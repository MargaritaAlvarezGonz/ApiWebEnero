using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserItem
    {
        public UserItem() 
        {
            IsActive = true;
        }

        public int Id { get; set; }
        public int IdPerson { get; set; }
        public int IdRol { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public bool IsActive { get; private set; }
        public string Name { get; internal set; }
        public string Password { get; internal set; }
        public DateTime InsertDate { get; internal set; }
        public DateTime UpdateDate { get; internal set; }
    }
}
