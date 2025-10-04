using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController(ApplicationDbContext context) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            List<Activity> activities = await context.Activities.ToListAsync();

            return activities;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetSingleActivity(string id)
        {
            Activity? activity = await context.Activities.FindAsync(id);

            if (activity == null)
            {
                return NotFound();
            }

            return activity;
        }
    }
}