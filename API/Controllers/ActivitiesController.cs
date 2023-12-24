using System.Diagnostics;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
//using Domain;
using Microsoft.AspNetCore.Cors;
using MediatR;
using Application.Activities;

namespace API.Controllers
{
     // Instead of [EnableCors("ReactivityPolicy")], we put "" the code in Program.cs.
     //[EnableCors("ReactivityPolicy")]
    public class ActivitiesController : BaseApiController
    {
        private readonly IMediator _mediator;
       
        public ActivitiesController(IMediator mediator)
        {
            _mediator = mediator;
           
            
        }
        // GET: api/Activities
        // [HttpGet]
        // public async Task<ActionResult<List<Domain.Activity>>> GetActivities()
        // {
        //     if(_context.Activities == null)
        //         return NotFound();
        //     return await _context.Activities.ToListAsync();
        // }


        [HttpGet]
        public async Task<ActionResult<List<Domain.Activity>>> GetActivities()
        {
            return await _mediator.Send(new List.Query());
        }



        // GET: api/Activities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Activity>> GetActivity(Guid id)
        {
            return Ok();
        }



    }
}