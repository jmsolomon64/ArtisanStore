using Microsoft.AspNetCore.Mvc;

namespace ArtisanStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class OrderController : Controller
    {
        private ArtisanStoreDbContext _context;
        public OrderController(ArtisanStoreDbContext db)
        {
            _context = db;
        }
    }
}