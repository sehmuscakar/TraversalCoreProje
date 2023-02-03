using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class boş
    {
        [Key]
        public int bosid { get; set; }

        public string surname { get; set; }
    }
}
