using Microsoft.AspNetCore.Mvc;

namespace ArtisanStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class ProductController : Controller
    {
        private ArtisanStoreDbContext _context;
        public ProductController(ArtisanStoreDbContext db)
        {
            _context = db;
        }
    }
}