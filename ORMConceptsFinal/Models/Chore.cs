namespace ORMConceptsFinal.Models
{
    public class Chore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public string Type { get; set; }
        public DateTime DueDate { get; set; }
        public bool Complete { get; set; }

        public Chore() { }
    }
}
