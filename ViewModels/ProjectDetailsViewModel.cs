using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyPortfolioo.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string CategoryName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public int TestimonialId { get; set; }
        public List<ImageViewModel> ProjectImages { get; set; }
    }
}
