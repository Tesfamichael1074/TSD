
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tsd_task_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipyController : ControllerBase
    {

        public RecipyController(ApplicationDbContext context)
        {
            _context = context;
        }
        private readonly ApplicationDbContext _context;


        // GET: api/Recipy
        [HttpGet]
        public IEnumerable<Recipy> Get()
        {
            var recipies = _context.Recipy.ToList();
            return recipies;
        }

        // GET: api/Recipy/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Recipy> Get(int id)
        {
            Recipy? recipy = _context.Recipy
                    .FirstOrDefault(m => m.Id == id);
            if (recipy != null) {
                return recipy;
            } else {
                return BadRequest("Recipy not found, please check the id!");
            }
        }

        // POST: api/Recipy
        [HttpPost]
        public Recipy Post(Recipy recipy)
        {
            recipy.NumOfLikes = 0;
            var new_recipy = _context.Add(recipy);
            _context.SaveChangesAsync();
            return new_recipy.Entity;
        }

        // PUT: api/Recipy/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Recipy recipy)
        {
            var new_recipy = _context.Recipy.FirstOrDefault(m => m.Id == id);
            if (new_recipy == null)
            {
                return BadRequest();
            }

            // For over-posting sample I left the Number of likes peoperty to not be able to be edited by the user
            new_recipy.Time = recipy.Time;
            new_recipy.Difficulty = recipy.Difficulty;
            new_recipy.Name = recipy.Name;
            new_recipy.Ingredients = recipy.Ingredients;
            new_recipy.Process = recipy.Process;
            new_recipy.TipsAndTricks = recipy.TipsAndTricks;

            await _context.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/Recipy/5
        [HttpDelete("{id}")]
        public ActionResult<Recipy> Delete(int id)
        {
            var recipy = _context.Recipy.FirstOrDefault(m => m.Id == id);
            if (recipy == null)
            {
                return BadRequest();
            }

            _context.Recipy.Remove(recipy);
            _context.SaveChangesAsync();

            return recipy;
        }
    }
}
