using Microsoft.AspNetCore.Mvc;

namespace ArtisanStore.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CategoryController : Controller
    {
        private ArtisanStoreDbContext _context;
        public CategoryController(ArtisanStoreDbContext db)
        {
            _context = db;
        }
    }
}