using Crud_UI.Models;
using CrudApi.DAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        IWorkerDal _workerDal;
        public WorkerController(IWorkerDal workerDal)
        {
            _workerDal = workerDal;
        }
        [HttpGet("get-all-workers")]
        public async Task<IActionResult> GetAllWorker()
        {
            List<Workers> returnData = _workerDal.GetAllWorkers();
            return Ok(returnData);

        }
        [HttpGet("get-worker")]
        public async Task<IActionResult> GetWorker(int workerId)
        {
            Workers returnData = _workerDal.GetWorker(workerId);
            return Ok(returnData);
        }
    }
}
