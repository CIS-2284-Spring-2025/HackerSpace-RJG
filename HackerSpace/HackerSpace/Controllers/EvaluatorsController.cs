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
        private ApplicationDbContext _context;

        public EvaluatorsController(ApplicationDbContext context)
        {
            _context=context;
        }

        // GET: api/<EvaluatorsController>
        [HttpGet]
        public async Task<List<Evaluator>> GetAsync()
        {
            return await _context.Evaluators.ToListAsync();
        }

        //// GET api/<EvaluatorsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<EvaluatorsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<EvaluatorsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<EvaluatorsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
