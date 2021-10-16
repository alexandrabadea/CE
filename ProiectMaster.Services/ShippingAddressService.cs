using AutoMapper;
using ProiectMaster.DataAccess.Interfaces;
using ProiectMaster.Models.DTOs.VM;
using ProiectMaster.Models.Entites;
using ProiectMaster.Models.Interfaces;
using System.Collections.Generic;

namespace ProiectMaster.Services
{
    public class ShippingAddressService : IShippingAddressService
    {
        private readonly IRepository<ShippingAddress, int> shippingAddressRep;
        private readonly IMapper mapper;

        public ShippingAddressService(IRepository<ShippingAddress, int> shippingAddressRep, IMapper mapper)
        {
            this.shippingAddressRep = shippingAddressRep;
            this.mapper = mapper;
        }

        public void AddShippingAddress(ShippingAddressVM dto)
        {
            var entity = mapper.Map<ShippingAddress>(dto);
            shippingAddressRep.Add(entity);
        }

        public void DeleteShippingAddress(int id)
        {
            var entity = shippingAddressRep.GetInstance(id);
            if (entity == null)
                return;

            shippingAddressRep.Delete(entity);
        }

        public IEnumerable<ShippingAddressVM> GetAllShippingAddresses()
        {
            var products = shippingAddressRep.GetAll();
            return mapper.Map<List<ShippingAddressVM>>(products);
        }

        public ShippingAddressVM GetShippingAddress(int id)
        {
            var entity = shippingAddressRep.GetInstance(id);
            return mapper.Map<ShippingAddressVM>(entity);
        }

        public void UpdateShippingAddress(int id, ShippingAddressVM dto)
        {
            var entity = shippingAddressRep.GetInstance(id);
            if (entity == null)
                return;

            mapper.Map(dto, entity);
            shippingAddressRep.Update(entity);
        }
    }
}
