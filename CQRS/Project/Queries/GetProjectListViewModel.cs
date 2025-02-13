namespace CompanyPortfolioo.CQRS.Project.Queries
{
    public class GetProjectListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string MainImagePath { get; set; }
        public int ProjectCategoryId { get; set; }
        public string ProjectCategoryName { get; set; }
        public string ProjectCategoryDescription { get; set; }
    }
}
