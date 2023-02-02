using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class RolItem
    {
        public RolItem() { }
        public int Id { get; set; }
        public string TipoRol { get; set; }
        public bool IsActive { get; set; }
    }
}
