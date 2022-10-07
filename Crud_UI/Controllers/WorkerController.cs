using Crud_UI.ApiServices;
using Crud_UI.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crud_UI.Controllers
{
    public class WorkerController : Controller
    {
        WorkerApiService _workerApiService;
        public WorkerController(WorkerApiService workerApiService)
        {
            _workerApiService = workerApiService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _workerApiService.GetAllWorkers();
            List<WorkerListDto> workerList = new List<WorkerListDto>();
            foreach (var item in data)
            {
                workerList.Add(new WorkerListDto(null, null, null, null, null)
                {
                    WorkerId = item.WorkerId,
                    WorkerName = item.WorkerName,
                    WorkerFactoryId = item.WorkerFactoryId,
                    WorkerPositionId = item.WorkerPositionId,
                    WorkerSurname = item.WorkerSurname,
                    Factory = item.WorkerFactory,
                    Position = item.WorkerPosition,

                });
            }
            return View(workerList);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var data = await _workerApiService.GetFactory(id);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Factory factory)
        {
            bool data = await _workerApiService.UpdateFactory(factory);
            return RedirectToAction("Index", "Factory");
        }

    }
}
