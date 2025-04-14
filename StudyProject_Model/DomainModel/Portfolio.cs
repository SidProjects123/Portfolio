namespace StudyProject_Model.DomainModel
{
    public class Portfolio
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Client { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; }

        public byte[]? PortfolioImg { get; set; }
    }
}
