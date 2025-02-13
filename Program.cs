using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.Services;
using CompanyPortfolioo.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.LoginPath = "/Account/Login";
            options.LogoutPath = "/Account/Logout";
        });

builder.Services.AddAuthorization(options => {
    options.AddPolicy("RequireAdminRole",
    policy => policy.RequireRole("Admin"));
});




builder.Services.AddScoped<IServicesRepository, ServicesRepository>(); 
builder.Services.AddScoped<IHorizontalSliderRepository, HorizontalSliderRepository>(); 
builder.Services.AddScoped<IAboutRepository, AboutRepository>();
builder.Services.AddScoped<IWhyUsRepository, WhyUsRepository>();
builder.Services.AddScoped<ISkillsRepository, SkillsRepository>();
builder.Services.AddScoped<IProjectsRepository, ProjectsRepository>(); 
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<IFeaturesRepository, FeaturesRepository>(); 
builder.Services.AddScoped<ITestimonialRepository, TestimonialRepository>(); 
builder.Services.AddScoped<IAskedQuestionRepository, AskedQuestionRepository>();
builder.Services.AddScoped<IContactUsRepository, ContactUsRepository>();
builder.Services.AddScoped<IProjectCategoryService, ProjectCategoryService>();
builder.Services.AddScoped<IProjectDetailsService, ProjectDetailsService>();
builder.Services.AddScoped<IAsyncRepository<AboutViewModel>, BaseRepository<AboutViewModel>>();
builder.Services.AddScoped<IAsyncRepository<AskedQuestionsViewModel>, BaseRepository<AskedQuestionsViewModel>>();
builder.Services.AddScoped<IAsyncRepository<WhyUsViewModel>, BaseRepository<WhyUsViewModel>>();
builder.Services.AddScoped<IAsyncRepository<ContactUsViewModel>, BaseRepository<ContactUsViewModel>>();
builder.Services.AddScoped<IAsyncRepository<PricingViewModel>, BaseRepository<PricingViewModel>>();
builder.Services.AddScoped<IAsyncRepository<ServicesViewModel>, BaseRepository<ServicesViewModel>>();
builder.Services.AddScoped<IAsyncRepository<HorizontalSliderViewModel>, BaseRepository<HorizontalSliderViewModel>>();
builder.Services.AddScoped<IAsyncRepository<SkillsViewModel>, BaseRepository<SkillsViewModel>>();
builder.Services.AddScoped<IAsyncRepository<ProjectViewModel>, BaseRepository<ProjectViewModel>>();
builder.Services.AddScoped<IAsyncRepository<TeamViewModel>, BaseRepository<TeamViewModel>>();
builder.Services.AddScoped<IAsyncRepository<TestimonialViewModel>, BaseRepository<TestimonialViewModel>>();
builder.Services.AddScoped<IAsyncRepository<ProjectCategoryViewModel>, BaseRepository<ProjectCategoryViewModel>>();
builder.Services.AddScoped<IAsyncRepository<ProjectDetailsViewModel>, BaseRepository<ProjectDetailsViewModel>>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}"
    );
app.Run();
