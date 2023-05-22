using ETicaretApp_EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_EntityLayer.Concrete
{
    public class Cart: BaseEntity
    {
        public string UserId { get; set; }

        public List<CartItem> CartItems { get; set; }
    }
}
