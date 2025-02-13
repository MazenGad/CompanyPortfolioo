using AutoMapper;
using CompanyPortfolioo.CQRS.ProjectDetails.Queries;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AboutUs, AboutViewModel>().ReverseMap();

            CreateMap<AskedQuestion, AskedQuestionsViewModel>().ReverseMap();
            CreateMap<CompanyInformation, CompanyInformationViewModel>().ReverseMap();
            CreateMap<ContactUs, ContactUsViewModel>().ReverseMap();
            CreateMap<HorizontalSlider, HorizontalSliderViewModel>().ReverseMap();

            CreateMap<Features, PricingViewModel>()
                .ForMember(dest => dest.PlanName, opt => opt.MapFrom(src => src.Pricing.PlanName))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Pricing.Price))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Pricing.IsActive))
                .ForMember(dest => dest.FeatureId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PriceId, opt => opt.MapFrom(src => src.Pricing.Id));

            CreateMap<Project, ProjectViewModel>()
                .ForMember(dest => dest.ProjectCategoryName, opt => opt.MapFrom(src => src.ProjectCategory.Name))
                .ForMember(dest => dest.ProjectCategoryDescription, opt => opt.MapFrom(src => src.ProjectCategory.Description))
                .ReverseMap();
            CreateMap<ProjectCategory, ProjectCategoryViewModel>().ReverseMap();
            CreateMap<ProjectDetails, ProjectDetailsViewModel>().ReverseMap();
            CreateMap<Service, ServicesViewModel>().ReverseMap();
            CreateMap<Skill, SkillsViewModel>().ReverseMap();
            CreateMap<Team, TeamViewModel>().ReverseMap();
            CreateMap<WhyUs, WhyUsViewModel>().ReverseMap();
            CreateMap<Testimonial, TestimonialViewModel>().ReverseMap();

            CreateMap<ProjectCategory, ProjectCategoryViewModel>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.MainImagePath, opt => opt.MapFrom(src => src.ImagePath))
                .ForMember(dest => dest.ProjectName, opt => opt.MapFrom(src => src.Projects.FirstOrDefault().Name))
                .ForMember(dest => dest.ProjectBio, opt => opt.MapFrom(src => src.Projects.FirstOrDefault().Bio))
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            {
                CreateMap<ProjectDetails, GetProjectDetailsViewModel>()
                    .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                    .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                    .ForMember(dest => dest.URL, opt => opt.MapFrom(src => src.URL))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.ProjectId, opt => opt.MapFrom(src => src.ProjectId))
                    .ForMember(dest => dest.TestimonialId, opt => opt.MapFrom(src => src.TestimonialId));

                CreateMap<ProjectImage, ImageViewModel>();



            }
        }
    }
}
