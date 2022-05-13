using Microsoft.AspNetCore.Mvc;
using NamePronunciation.Services;
using NamePronunciation.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NamePronunciation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamePronunciation : ControllerBase
    {
        private readonly IPronunciationService pronunciationService;
        public NamePronunciation(IPronunciationService pronunciationService)
        {
            this.pronunciationService = pronunciationService;
        }
        // GET: api/<NamePronunciation>
        
        [HttpGet("{Name}")]
        public string GetNameforStandardPronunciation(string Name)
        {
            return pronunciationService.GetStandardPronunciation(Name);
        }
        [HttpGet("{Name}")]
        public string GetPhoneticsforStandardPronunciation(string Name)
        {
            return pronunciationService.GetPhoneticsforName(Name);
        }

        // POST api/<NamePronunciation>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NamePronunciation>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NamePronunciation>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
