using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserItem
    {
        public UserItem() { }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public string DNI { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Password { get; set; }
        private string EncryptedPassword { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }



    }
}
