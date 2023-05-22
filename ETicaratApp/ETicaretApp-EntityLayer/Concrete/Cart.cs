using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_EntityLayer.Concrete
{
    public class Cart
    {
        public string UserId { get; set; }

        public List<CartItem> CartItems { get; set; }
    }
}
