using System.Diagnostics;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
//using Domain;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
     // Instead of [EnableCors("ReactivityPolicy")], we put "" the code in Program.cs.
     //[EnableCors("ReactivityPolicy")]
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
            
        }
        // GET: api/Activities
        [HttpGet]
        public async Task<ActionResult<List<Domain.Activity>>> GetActivities()
        {
            if(_context.Activities == null)
                return NotFound();
            return await _context.Activities.ToListAsync();
        }

        // GET: api/Activities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Activity>> GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }



    }
}