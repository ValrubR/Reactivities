//using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain;

namespace API.Controllers
{

    public class ActivitiesController: BaseApiController
    {
        private readonly DataContext _context;
      
        public ActivitiesController(DataContext context)
        {
            _context = context;
           
            
        }

        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();

        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id) //api/activities/jdbfjs
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}