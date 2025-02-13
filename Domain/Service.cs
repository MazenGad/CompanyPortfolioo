namespace CompanyPortfolioo.Domain
{
    public class Service
    {
        public int Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string ShortDescAr { get; set; }
        public string ShortDescEn { get; set; }
        public string LongDescAr { get; set; }
        public string LongDescEn { get; set; }
        public string? Image { get; set; }
        public bool ShowHome { get; set; }
        public bool IsActive { get; set; }


	}
}
