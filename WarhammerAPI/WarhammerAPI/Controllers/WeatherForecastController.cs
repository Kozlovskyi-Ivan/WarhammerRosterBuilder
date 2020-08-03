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
        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        //Unit unit = new Unit() { Name= "Canoptek Scarabs"};
        //        //Models models = new Models() { BS = 0, WS = 4, Move = 10, Strength = 3, Toughness = 3, Attack = 4, Leadership = 10, Save = 6, Cost = 13, Name = "Canoptek Scarab Swarm" };
        //        //List<Models> modelsL = new List<Models>();
        //        //modelsL.Add(models);
        //        ////unit.Models.Add(models);
        //        //unit.Models = modelsL;
        //        //unit.UnitType = new UnitType() { Type = "Fast Attack" };
        //        //unit.UnitNumber = new UnitNumber() { NumberMin = 3, NumberMax = 9, PowerPoints = 2, PowerPointsMax = 6 };
        //        //AbilitiesWeapon abilitiesWeapon = new AbilitiesWeapon() { Description= "If the target’s Toughness is higher than this attack’s Strength, this weapon always wounds the target on a wound roll of 5+." };
        //        //Weapon weapon = new Weapon() {Name= "Feeder mandibles",Range= "Melee", Type= "Melee",Strength="User",AP="0",Damage="1",Cost=0 };
        //        ////weapon.AbilitiesWeapon.Add(abilitiesWeapon);
        //        //List<Weapon> weapons = new List<Weapon>() { weapon};
        //        //WeaponSet weaponSet = new WeaponSet() {BuildIn=true };
        //        ////weaponSet.Weapon.Add(weapon);
        //        //List<WeaponSet> weaponSets = new List<WeaponSet>() { weaponSet };
        //        //WargearSetUp wargearSetUp = new WargearSetUp();
        //        ////wargearSetUp.WeaponSet.Add(weaponSet);
        //        //List<WargearSetUp> wargearSetUps = new List<WargearSetUp>() { wargearSetUp };
        //        //WargearOptions wargearOptions = new WargearOptions();
        //        ////wargearOptions.WargearSet.Add(wargearSetUp);
        //        //List<WargearOptions> wargearOptions1 = new List<WargearOptions>() { wargearOptions };
        //        ////unit.WargearOptions.Add(wargearOptions);
        //        //unit.WargearOptions = wargearOptions1;
        //        //db.SaveChanges();
        //    }
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
                //Unit unit = new Unit() { Name = "Canoptek Scarabs" };
                //Models models = new Models() { BS = 0, WS = 4, Move = 10, Strength = 3, Toughness = 3, Attack = 4, Leadership = 10, Save = 6, Cost = 13, Name = "Canoptek Scarab Swarm" };
                //List<Models> modelsL = new List<Models>();
                //modelsL.Add(models);
                //unit.Models = modelsL;
                //unit.UnitType = new UnitType() { Type = "Fast Attack" };
                //unit.UnitNumber = new UnitNumber() { NumberMin = 3, NumberMax = 9, PowerPoints = 2, PowerPointsMax = 6 };
                ////abilities
                //List<AbilitiesWeapon> abilities = new List<AbilitiesWeapon>();
                //AbilitiesWeapon abilitiesWeapon = new AbilitiesWeapon() { Description = "If the target’s Toughness is higher than this attack’s Strength, this weapon always wounds the target on a wound roll of 5+." };
                //abilities.Add(abilitiesWeapon);
                ////Weapon
                //Weapon weapon = new Weapon() { Name = "Feeder mandibles", Range = "Melee", Type = "Melee", Strength = "User", AP = "0", Damage = "1", Cost = 0 };
                //weapon.AbilitiesWeapon = abilities;
                //List<Weapon> weapons = new List<Weapon>();
                //weapons.Add(weapon);
                ////weaponSet
                //WeaponSet weaponSet = new WeaponSet();
                //weaponSet.Weapon = weapons;
                //List<WeaponSet> weaponSets = new List<WeaponSet>();
                //weaponSets.Add(weaponSet);
                ////wargearSetUp
                //WargearSetUp wargearSetUp = new WargearSetUp();
                //wargearSetUp.WeaponSet = weaponSets;
                //List<WargearSetUp> wargearSetUps = new List<WargearSetUp>();
                //wargearSetUps.Add(wargearSetUp);
                ////wargearOptions
                //WargearOptions wargearOptions = new WargearOptions();
                //wargearOptions.WargearSet = wargearSetUps;
                //List<WargearOptions> wargearOptions1 = new List<WargearOptions>();
                //wargearOptions1.Add(wargearOptions);

                //unit.WargearOptions = wargearOptions1;
                //db.Unit.Add(unit);
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
