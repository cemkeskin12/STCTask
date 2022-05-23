namespace WebMvc.Entities
{
    public class Section : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Worker> Worker { get; set; }
        
    }
}
