namespace CompanyPortfolioo.Domain
{
    public class Pricing
    {
        public int Id { get; set; }
        public string PlanName { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Features> Features { get; set; }

    }
}
