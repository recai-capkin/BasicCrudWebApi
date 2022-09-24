using Crud_UI.ApiServices;
using Crud_UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crud_UI.Controllers
{
    public class FactoryController : Controller
    {
        FactoryApiService _factoryApiService;
        public FactoryController(FactoryApiService factoryApiService)
        {
            _factoryApiService = factoryApiService;
        }
        public async Task<IActionResult> Index()
        {
            List<Factory> data = await _factoryApiService.GetAllFactory();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Factory factory)
        {
            var data = await _factoryApiService.AddFactory(factory);
            return RedirectToAction("Index", "Factory");
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var data = await _factoryApiService.GetFactory(id);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Factory factory)
        {
            bool data = await _factoryApiService.UpdateFactory(factory);
            return RedirectToAction("Index", "Factory");
        }

    }
}
