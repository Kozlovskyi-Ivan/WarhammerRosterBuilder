using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WarhammerAPI.Model.DAL.EF;
using WarhammerAPI.Model.DAL.Entities;

namespace WarhammerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();

        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                TestData data = new TestData();
                data.Start();
                //db.SaveChanges();
                var unitS = db.Unit.FirstOrDefault((x) => x.Name == "Canoptek Scarabs");
                var unit1 = (from n in db.Unit.Include((x) => x.WargearOptions)
                             .ThenInclude(x => x.WargearSet)
                             .ThenInclude(x => x.WeaponSet)
                             .ThenInclude(x => x.Weapon)
                             .ThenInclude(x=>x.AbilitiesWeapon)
                             .Include(x=>x.Models)
                             .Include(x=>x.UnitType)
                             .Include(x=>x.UnitNumber)
                                 //where n.Unit == unitS
                             orderby n
                             select n).ToList();
                return Ok(unit1);
                //return db.Unit.ToList();
                //.ThenInclude(x => x.WargearSet).ThenInclude(x => x.).ThenInclude(x => x.WeaponSet).ThenInclude(x => x.Weapon)
            }
            
        }
    }
}
