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

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromForm] UserEdit model)
        {
            if (!ModelState.IsValid) //checks to see if model inserted is valid
            {
                return BadRequest(ModelState); //will let user know request was invalid
            }

            _context.Users.Add(new User()
            { //All properties will be recieved from form expect Joined which pulls the current date time
                Name = model.Name,
                Joined = DateTime.Now,
                IsVendor = model.isVendor,
                IsAdvertiser = model.IsAdvertiser
            });

            await _context.SaveChangesAsync();
            return Ok();
        }

        
    }
}