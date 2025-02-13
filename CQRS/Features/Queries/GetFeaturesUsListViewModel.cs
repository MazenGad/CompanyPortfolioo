namespace CompanyPortfolioo.CQRS.Features.Queries
{
    public class GetFeaturesListViewModel
    {
        public string PlanName { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public bool IsActiveFeature { get; set; }
        public bool IsActive { get; set; }
        public int FeatureId { get; set; }
        public int PriceId { get; set; }
    }
}
