using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarhammerAPI.Model.DAL.EF;
using WarhammerAPI.Model.DAL.Interfaces;
using WarhammerAPI.Model.DAL.Repositories;

namespace WarhammerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsController:ControllerBase
    {
        private readonly ILogger<UnitsController> _logger;

        public UnitsController(ILogger<UnitsController> logger)
        {
            _logger = logger;
        }
        //GET api/Units
        [HttpGet]
        public async Task<IActionResult> GetAllUnits()
        {
            IRepositoryUnit unit = new UnitRepository();
            return Ok(unit.GetAll());
        }
        //GET api/Units/Name
        [HttpGet("{Name}")]
        public async Task<IActionResult> GetUnitByName([FromRoute] string Name)
        {
            IRepositoryUnit unit = new UnitRepository();
            return Ok(unit.FindByName(Name));
        }

    }
}
