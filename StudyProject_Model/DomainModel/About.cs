namespace StudyProject_Model.DomainModel
{
    public class About
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string SubTitle { get; set; }

        public required string Description { get; set; }

        public byte[]? AboutImg { get; set; }
    }
}
