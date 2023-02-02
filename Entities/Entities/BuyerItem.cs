using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class BuyerItem
    {
        public BuyerItem() 
        {
            IsActive = true;
        }

        public int Id { get; set; }
        public int IdPerson { get; set; }
        public string UserName { get; set; }
        public int OrderId { get; set; }
        public int IdRol { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; private set; }






























    }
}
