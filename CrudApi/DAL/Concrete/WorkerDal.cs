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

        public Workers GetWorkers(int workerId)
        {
            throw new System.NotImplementedException();
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
