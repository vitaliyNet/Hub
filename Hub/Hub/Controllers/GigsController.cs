using Hub.Models;
using Hub.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace Hub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel model)
        {
            //var artist = _context.Users.Single(u => u.Id == User.Identity.GetUserId());
           // var genre = _context.Genres.Single(g => g.Id == model.Genre);
            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = model.DateTime,
                GenreId = model.Genre,
                Venue = model.Venue
                
            };
            _context.Gigs.Add(gig);
            _context.SaveChanges();
            return RedirectToAction("Index" ,"Home");
        }
    }
}