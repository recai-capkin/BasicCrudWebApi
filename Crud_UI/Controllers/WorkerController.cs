using Crud_UI.ApiServices;
using Crud_UI.Dtos;
using Crud_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            Workers workers = await _workerApiService.GetWorker(id);

            WorkerUpdateDto workerUpdateDto = new(workers.WorkerId, workers.WorkerName,workers.WorkerSurname,workers.WorkerFactoryId,workers.WorkerPositionId);
            workerUpdateDto.FactoryItemList = new List<SelectListItem>()
            {
                new SelectListItem(){ Text="Sanofi",Value="1"},
                new SelectListItem(){ Text="BilgeAdam",Value="2"}
            };


            return View(workerUpdateDto);
        }


        [HttpPost]
        public async Task<IActionResult> Update(Workers factory)
        {
            //bool data = await _workerApiService.UpdateFactory(factory);
            //return RedirectToAction("Index", "Factory");
            return View();
        }

    }
}
