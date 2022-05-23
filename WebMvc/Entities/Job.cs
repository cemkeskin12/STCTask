namespace WebMvc.Entities
{
    public class Job : BaseEntity
    {
        public string Name { get; set; }

        public int SectionId { get; set; }
        public Section Section { get; set; }
        public ICollection<Worker> Worker { get; set; }

    }
}
