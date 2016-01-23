using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using bowlgames_api.Models;

namespace bowlgames_api.Controllers
{
    [Route("api/[controller]")]
    public class TeamsController : Controller
    {
        private readonly BowlGamesContext _context;

        public TeamsController(BowlGamesContext context)
        {
            _context = context;
        }

        // GET: api/teams
        [HttpGet]
        public IEnumerable<Team> Get()
        {
            return _context.Teams.ToList();
        }

        // GET api/teams/5
        [HttpGet("{id}")]
        public Team Get(int id)
        {
            return _context.Teams.FirstOrDefault(t => t.Id == id);
        }
    }
}
