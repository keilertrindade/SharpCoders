using HelloWorldApi.Domain;
using HelloWorldApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Controllers
{
    [ApiController]
    [Route("heroes")]
    public class HeroController : ControllerBase
    {
        private static List<Hero> _heroes = new List<Hero>
        {
            new Hero { Name = "Superman", RealName = "Clark Kent", Age = 35, Power = "Super strength", isRetired = false },
            new Hero { Name = "Batman", RealName = "Bruce Wayne", Age = 40, Power = "Intelligence", isRetired = false },
            new Hero { Name = "Wonder Woman", RealName = "Diana Prince", Age = 27, Power = "Superhuman strength", isRetired = false },
            new Hero { Name = "Spider-Man", RealName = "Peter Parker", Age = 23, Power = "Spider-sense", isRetired = false },
            new Hero { Name = "Iron Man", RealName = "Tony Stark", Age = 45, Power = "Armor suit", isRetired = false },
            new Hero { Name = "Green Arrow", RealName = "Oliver Queen", Age = 50, Power = "Archery", isRetired = true },
            new Hero { Name = "Flash", RealName = "Barry Allen", Age = 30, Power = "Super speed", isRetired = true },
            new Hero { Name = "Aquaman", RealName = "Arthur Curry", Age = 38, Power = "Hydrokinesis", isRetired = true },
            new Hero { Name = "Ms. Marvel", RealName = "Kamala Khan", Age = 16, Power = "Shapeshifting", isRetired = false },
            new Hero { Name = "Robin", RealName = "Damian Wayne", Age = 14, Power = "Acrobatics", isRetired = false },
            new Hero { Name = "Nova", RealName = "Sam Alexander", Age = 17, Power = "Energy projection", isRetired = false },
            new Hero { Name = "Thor", RealName = "Thor Odinson", Age = 1500, Power = "Godly powers", isRetired = false },
            new Hero { Name = "Hulk", RealName = "Bruce Banner", Age = 40, Power = "Superhuman strength", isRetired = false },
            new Hero { Name = "Doctor Strange", RealName = "Stephen Strange", Age = 45, Power = "Mystic arts", isRetired = false },
            new Hero { Name = "Captain America", RealName = "Steve Rogers", Age = 100, Power = "Superhuman strength", isRetired = false },
            new Hero { Name = "Black Widow", RealName = "Natasha Romanoff", Age = 35, Power = "Espionage", isRetired = false },
            new Hero { Name = "Hawkeye", RealName = "Clint Barton", Age = 42, Power = "Archery", isRetired = false },
            new Hero { Name = "Scarlet Witch", RealName = "Wanda Maximoff", Age = 33, Power = "Reality-warping", isRetired = false },
            new Hero { Name = "Vision", RealName = "Vision", Age = 3, Power = "Synthetic powers", isRetired = false },
        };

        private HeroContext _context;

        public HeroController(HeroContext heroContext)
        {
            _context = heroContext;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Hero>> GetAllHeroes(
            [FromQuery] bool includeRetired = true) //Pode-se usar o IActionResult
        {
            var heroes = _context.Heroes.ToList();

            if (heroes.Count == 0)
                return NotFound(new
                {
                    message = "Cannot find any hero in heroes db",
                    moment = DateTime.UtcNow
                });

            return Ok(includeRetired ? 
                heroes :
                heroes.Where(h => !h.isRetired) 
                );
        }
        [HttpGet]
        [Route("/{id}")]
        public IActionResult GetHeroById(int id)
        {
            var hero = _context.Heroes.FirstOrDefault(h => h.Id == id);
            if (hero == null) return NotFound();
            return Ok(hero);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateNewHero([FromBody] Hero hero)
        {
          var createdHero = _context.Heroes.Add(hero).Entity;
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetHeroById), new {id = hero.Id }, hero);
        }
    }
}
