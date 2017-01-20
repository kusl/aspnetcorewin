using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspnetCoreWin.Controllers
{
    [Route("api/[controller]")]
    public class CoinFlipperController : Controller
    {
        // GET: api/coinflipper
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "heads", "tails" };
        }

        // GET api/coinflipper/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Random r = new Random();
            if (r.Next(0, 10) > 5)
            {
                return "heads";
            }
            else
            {
                return "tails";
            }
        }

        // POST api/coinflipper
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/coinflipper/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/coinflipper/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
