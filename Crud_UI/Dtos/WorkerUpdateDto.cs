using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Crud_UI.Dtos
{
    public record WorkerUpdateDto(int? WorkerId, string WorkerName, string WorkerSurname, int? WorkerFactoryId, int? WorkerPositionId)
    {
        
        public List<SelectListItem> FactoryItemList
        {
            get; set;
        }
    }
}
