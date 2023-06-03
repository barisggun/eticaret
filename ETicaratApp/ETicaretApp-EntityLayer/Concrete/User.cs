using ETicaretApp_EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_EntityLayer.Concrete
{
    public class User : BaseEntity
    {
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Kullanıcı Kullanıcı { get; set; }
    }

    public enum Kullanıcı
    {
        Admin,
        User
    }
}
