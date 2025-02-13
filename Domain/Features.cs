using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyPortfolioo.Domain
{
    public class Features
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActiveFeature { get; set; }
        [ForeignKey("Pricing")]
        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
    }
}
