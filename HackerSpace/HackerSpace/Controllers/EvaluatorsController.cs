using Entities.Interfaces;
using Entities.Models;
using HackerSpace.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HackerSpace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluatorsController : ControllerBase
    {
        private IEvaluatorsDataService _dataService;

        public EvaluatorsController(IEvaluatorsDataService dataService)
        {
            _dataService = dataService;
        }

        // GET: api/<EvaluatorsController>
        [HttpGet]
        public async Task<List<Evaluator>?> GetAsync()
        {
            return await _dataService.GetAllAsync();
        }

        // GET api/<EvaluatorsController>/5
        [HttpGet("{id}")]
        public async Task<Evaluator?> GetAsync(string id)
        {
            return await _dataService.GetAsync(Guid.Parse(id));
        }


        // POST api/<EvaluatorsController>
        [HttpPost]
        public async Task PostAsync([FromBody] Evaluator evaluator)
        {
            await _dataService.AddAsync(evaluator);
        }

        //// PUT api/<EvaluatorsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<EvaluatorsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _dataService.DeleteAsync(Guid.Parse(id));
        }

        // GET: api/<EvaluatorsController>
        [HttpGet]
        [Route("Badges")]
        public async Task<List<Badge>?> GetApplicationUsersAsync()
        {
            return await _dataService.GetBadgesAsync();
        }

        // GET: api/<EvaluatorsController>
        [HttpGet]
        [Route("AppUsers")]
        public async Task<List<ApplicationUser>?> GetBadgesAsync()
        {
            return await _dataService.GetApplicationUsersAsync();
        }
    }
}
