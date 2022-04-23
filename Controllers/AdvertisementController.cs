using Microsoft.AspNetCore.Mvc;

namespace ArtisanStore.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AdvertisementController : Controller 
    {
        private ArtisanStoreDbContext _context;
        public AdvertisementController(ArtisanStoreDbContext db)
        {
            _context = db;
        }
    }
}