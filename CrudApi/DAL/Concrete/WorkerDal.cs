using Crud_UI.Models;
using Crud_UI.Models.Context;
using CrudApi.DAL.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CrudApi.DAL.Concrete
{
    public class WorkerDal : IWorkerDal
    {
        BaseContext _baseContext;
        public WorkerDal(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public bool AddWorkers(Workers workers)
        {
            throw new System.NotImplementedException();
        }

        public List<Workers> GetAllWorkers()
        {
            List<Workers> factories = _baseContext.Workers.Include(x => x.WorkerFactory).Include(x => x.WorkerPosition).ToList();
            return factories;
        }

        public Workers GetWorker(int workerId)
        {
            Workers workers = _baseContext.Workers.Include(x => x.WorkerFactory).Include(y => y.WorkerPosition).Where(x => x.WorkerId == workerId).FirstOrDefault();
            return workers;
        }

        public bool RemoveWorkers(int workerId)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateWorkers(Workers workers)
        {
            throw new System.NotImplementedException();
        }
    }
}
