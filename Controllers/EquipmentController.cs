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
    }
}
