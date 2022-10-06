using front_to_back.DAL;
using front_to_back.ViewModels.Contact;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace front_to_back.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ContactController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var contractIntroComponent = await _appDbContext.ContactIntroComponent.FirstOrDefaultAsync();
            var contactCreateComponent = await _appDbContext.ContactCreateComponent.FirstOrDefaultAsync();
            var contactMediaComponent = await _appDbContext.ContactMediaComponents.ToListAsync();

            var model = new ContactIndexViewModel
            {
                ContactIntroComponent = contractIntroComponent,
                ContactCreateComponent = contactCreateComponent,
                ContactMediaComponents = contactMediaComponent
            };

            return View(model);
        }
    }
}
