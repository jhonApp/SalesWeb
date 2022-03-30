using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWeb.Models
{
    [Table("Department")]
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
