using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models.Entites
{
    public partial class ShippingAddress : IEntity<int>
    {
        public ShippingAddress()
        {
        }

        public int Id { get; set; }
        public string PersonName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

    }
}
