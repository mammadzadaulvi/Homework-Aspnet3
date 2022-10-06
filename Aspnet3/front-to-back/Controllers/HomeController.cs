using front_to_back.DAL;
using front_to_back.Models;
using front_to_back.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace front_to_back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;   
        }
        public async Task<IActionResult> Index()
        {
            var recentWorkComponents = await _appDbContext.RecentWorkComponents.ToListAsync();


            var projectComponents = new List<ProjectComponent>
            {
                new ProjectComponent{Title = "UX/UI design", Text = "UI/UX design text", FilePath = "/assets/img/services-01.jpg"},
                new ProjectComponent{Title = "Social Media", Text = "Social Media text", FilePath = "/assets/img/services-02.jpg"},
                new ProjectComponent{Title = "Marketing", Text = "Marketing text", FilePath = "/assets/img/services-03.jpg"},
                new ProjectComponent{Title = "Graphic", Text = "Graphic text", FilePath = "/assets/img/services-04.jpg"}
            };

            //var recentWorkComponents = new List<RecentWorkComponent> {
            //    new RecentWorkComponent{Title = "Social", Text = "Social text", FilePath = "/assets/img/recent-work-01.jpg"},
            //    new RecentWorkComponent{Title = "Unsocial", Text = "Unsocial text", FilePath = "/assets/img/recent-work-02.jpg"},
            //    new RecentWorkComponent{Title = "Market", Text = "Market text", FilePath = "/assets/img/recent-work-03.jpg"}
            //};


            var model = new HomeIndexViewModel
            {
                ProjectComponents = projectComponents,
                RecentWorkComponents = recentWorkComponents
            };

            return View(model);
        }
    }
}
