namespace WebMvc.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Section> Sections { get; set; }
        public ICollection<Worker> Worker { get; set; }

    }
}
