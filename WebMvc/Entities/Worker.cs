using System.ComponentModel.DataAnnotations.Schema;

namespace WebMvc.Entities
{
    public class Worker : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
        public int? SectionId { get; set; }

        public Section Section { get; set; }
        public int? JobId { get; set; }

        public Job Job { get; set; }
    }
}
