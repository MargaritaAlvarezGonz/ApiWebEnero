using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class OrderItem //Aquì habìa puesto ProductItem como si dependiera de èl pero no me salió
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int BuyerId { get; set; }
        public Guid IdWeb { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsPayed { get; set; }
        public bool IsShipped { get; set; }



    }
}
