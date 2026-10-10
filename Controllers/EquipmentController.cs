using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EquipmentTool.Models;

namespace EquipmentTool.Controllers
{
    public class EquipmentController : Controller
    {
        [HttpGet]
        [Route("RequestForm")]
        public IActionResult RequestForm()
        {
            return View();
        }

        [HttpPost]
        [Route("RequestForm")]
        public IActionResult RequestForm(EquipmentRequest request)
        {
            if (ModelState.IsValid)
            {
                Repository.AddRequest(request);
                return View("Confirmation", request);
            }
            return View(request);
        }

        [HttpGet]
        [Route("AllEquipment")]
        public IActionResult AllEquipment()
        {
            return View(Repository.AllEquipment);
        }

        [HttpGet]
        [Route("AvailableEquipment")]
        public IActionResult AvailableEquipment()
        {
            var availableItems = Repository.AllEquipment.Where(e => e.IsAvailable);
            return View(availableItems);
        }

        [HttpGet]
        [Route("Requests")]
        public IActionResult Requests()
        {
            return View(Repository.Requests);
        }
    }
}
