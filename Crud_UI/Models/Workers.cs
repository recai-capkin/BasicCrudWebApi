using System.ComponentModel.DataAnnotations;

namespace Crud_UI.Models
{
    public class Workers
    {
        [Key]
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public int WorkerFactoryId { get; set; }
        public Factory WorkerFactory { get; set; }
        public int WorkerPositionId { get; set; }
        public Position WorkerPosition { get; set; }
    }
}
