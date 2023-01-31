using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class AdminItem : UserItem
    {
        public AdminItem() 
        {
            IsActive = true;
        }

        //public int Id { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public int IdRol { get; set; }
        public bool IsActive { get; private set; }


    }
}
