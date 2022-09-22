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
    }
}
