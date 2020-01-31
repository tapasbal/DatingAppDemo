using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore; 


namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        
        private readonly DataContext _context;
        public ValueController(DataContext context)
        {
            _context = context;
        }

        //GET api value
        // [HttpGet] 
        // public IActionResult GetValues()
        // {
        //     var values = _context.Values.ToList();
        //     return Ok(values);
        // }

        //GET api value
        [HttpGet] 
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }


        //GET api/values/5
        // [HttpGet("{id}")]
        // public IActionResult GetValue(int id)
        // {
        //     var value = _context.Values.FirstOrDefault(x => x.Id == id);

        //     return Ok(value);
        // }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value =await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
        }
    }
}