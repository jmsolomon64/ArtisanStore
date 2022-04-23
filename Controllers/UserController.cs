using Microsoft.AspNetCore.Mvc;

namespace ArtisanStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private ArtisanStoreDbContext _context;
        public UserController(ArtisanStoreDbContext db)
        {
            _context = db; 
        }

        
    }
}