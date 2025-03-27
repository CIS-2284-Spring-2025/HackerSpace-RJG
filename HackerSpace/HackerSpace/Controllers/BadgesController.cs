using Entities.Interfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HackerSpace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BadgesController : ControllerBase
    {
        private IBadgesPageDataService _dataService;
        public BadgesController(IBadgesPageDataService dataService)
        {
            _dataService = dataService;
        }

        // GET: api/<BadgesController>
        [HttpGet]
        public async Task<List<Badge>?> GetAsync()
        {
            return await _dataService.GetAllAsync();
        }

        // GET api/<BadgesController>/5
        [HttpGet("{id}")]
        public async Task<Badge?> GetAsync(Guid id)
        {
            return await _dataService.GetBadgeAsync(id);
        }

        //// POST api/<BadgesController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<BadgesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<BadgesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
