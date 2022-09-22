using System.ComponentModel.DataAnnotations;

namespace Crud_UI.Models
{
    public class Factory
    {
        [Key]
        public int FactoryId { get; set; }
        public string FactoryName { get; set; }
    }
}
