using front_to_back.DAL;
using front_to_back.Models;
using front_to_back.ViewModels.About;
using Microsoft.AspNetCore.Mvc;

namespace front_to_back.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _appDbContext;    
        public AboutController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;   
        }

        public IActionResult Index()
        {
            var aimComponents = new List<AimComponent>
            {
                new AimComponent{Title = "Vision", Text = "Vision text", FilePath = "display-4 bx bxs-bulb text-light"},
                new AimComponent{Title = "Mission", Text = "Mission text", FilePath = "display-4 bx bx-revision text-light"},
                new AimComponent{Title = "Goal", Text = "Goal text", FilePath = "display-4 bx bxs-select-multiple text-light"}
            };

            var model = new AboutIndexViewModel
            {
                AimComponents = aimComponents
            };

            return View(model);
        }
    }
}
