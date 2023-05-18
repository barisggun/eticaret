using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_EntityLayer.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        //public DateTime CreatedDateTime { get; set; }
        //public DateTime UpdatedDateTime { get; set; }
    }
}
