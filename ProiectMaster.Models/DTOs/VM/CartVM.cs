using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models.DTOs.VM
{
    class CartVM
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public virtual Entites.Order Order { get; set; }
        public virtual Entites.Product Product { get; set; }
    }
}
