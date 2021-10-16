using Microsoft.AspNetCore.Mvc;
using ProiectMaster.Models.DTOs.VM;
using ProiectMaster.Models.Interfaces;

namespace ProiectMaster.Web.Controllers
{
    [Route("[Controller]")]
    public class ShippingAddressController : Controller
    {
        private readonly IShippingAddressService service;

        public ShippingAddressController(IShippingAddressService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var list = service.GetAllShippingAddresses();
            return View(list);
        }

        [HttpGet]
        [Route("New")]
        public IActionResult New()
        {
            var dto = new ShippingAddressVM();
            return View(dto);
        }

        [HttpPost]
        [Route("New")]
        public IActionResult New(ShippingAddressVM dto)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "There were some errors in your form");
                return View(dto);
            }

            service.AddShippingAddress(dto);

            return View("Index", service.GetAllShippingAddresses());
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var dto = service.GetShippingAddress(id);
            return View(dto);
        }

        [HttpPost]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id, ShippingAddressVM dto)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "There were some errors in your form");
                return View(dto);
            }

            service.UpdateShippingAddress(id, dto);

            return View("Index", service.GetAllShippingAddresses());
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public JsonResult Delete(int id)
        {
            service.DeleteShippingAddress(id);
            return Json(new { success = true, message = "Delete success" });
        }
    }
}
