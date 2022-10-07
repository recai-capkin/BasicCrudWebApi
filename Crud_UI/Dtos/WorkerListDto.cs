using Crud_UI.Models;
using System.Collections.Generic;

namespace Crud_UI.Dtos
{
    public record WorkerListDto(int? WorkerId,string WorkerName,string WorkerSurname, int? WorkerFactoryId, int? WorkerPositionId)
    {
        public Position Position;
        public Factory Factory;
    }
}
