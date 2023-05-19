using ETicaretApp_EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_EntityLayer.Concrete
{
    public class Customer:BaseEntity
    {
        public string? FullName { get; set; }
        public string? Mail { get; set; }
        public string? Password { get; set; }
        public int? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? BirthDate { get; set; }
        public string? Gender { get; set; } 
        public Sale? Sale { get; set; }
    }
}
