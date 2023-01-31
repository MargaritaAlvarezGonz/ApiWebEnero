using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductItem
    {
        public ProductItem() {
            IsActive = true;
            IsPublic = true;
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public int ProductId { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; private set; }
        public bool IsPublic { get; private set;}

        public string Name { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public int Stock { get; set; }
        public decimal RawPrice { get; set; }

       


    }
}
