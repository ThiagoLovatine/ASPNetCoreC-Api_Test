using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private static readonly string[] Names = new[]
        {
            "Thiago", "Beatriz"
        };

        [HttpGet]
        public IEnumerable<HomeData> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5000).Select(index => new HomeData
            {
                Date = DateTime.Now.AddDays(index),
                Name = Names[rng.Next(Names.Length)]
            })
            .ToArray();
        }
    }
}
