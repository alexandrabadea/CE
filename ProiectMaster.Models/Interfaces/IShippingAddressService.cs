using ProiectMaster.Models.DTOs.VM;
using System.Collections.Generic;

namespace ProiectMaster.Models.Interfaces
{
    public interface IShippingAddressService
    {
        IEnumerable<ShippingAddressVM> GetAllShippingAddresses();
        ShippingAddressVM GetShippingAddress(int id);
        void AddShippingAddress(ShippingAddressVM dto);
        void UpdateShippingAddress(int id, ShippingAddressVM dto);
        void DeleteShippingAddress(int id);
    }
}
