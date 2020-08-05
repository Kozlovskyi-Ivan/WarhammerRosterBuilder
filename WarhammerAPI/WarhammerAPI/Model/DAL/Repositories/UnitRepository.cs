using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarhammerAPI.Model.DAL.EF;
using WarhammerAPI.Model.DAL.Entities;
using WarhammerAPI.Model.DAL.Interfaces;

namespace WarhammerAPI.Model.DAL.Repositories
{
    public class UnitRepository : IRepositoryUnit
    {
        public Unit FindByName(string Name)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                //var unitS = db.Unit.FirstOrDefault((x) => x.Name == "Canoptek Scarabs");
                var units = (from n in db.Unit.Include((x) => x.WargearOptions)
                             .ThenInclude(x => x.WargearSet)
                             .ThenInclude(x => x.WeaponSet)
                             .ThenInclude(x => x.Weapon)
                             .ThenInclude(x => x.AbilitiesWeapon)
                             .Include(x => x.Models)
                             .Include(x => x.UnitType)
                             .Include(x => x.UnitNumber)
                             where n.Name==Name
                             orderby n
                             select n).FirstOrDefault();
                //return ((Unit)unit1);
                return units;
            }
        }

        public List<Unit> GetAll()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var units = (from n in db.Unit.Include((x) => x.WargearOptions)
                             .ThenInclude(x => x.WargearSet)
                             .ThenInclude(x => x.WeaponSet)
                             .ThenInclude(x => x.Weapon)
                             .ThenInclude(x => x.AbilitiesWeapon)
                             .Include(x => x.Models)
                             .Include(x => x.UnitType)
                             .Include(x => x.UnitNumber)
                             orderby n
                             select n).ToList();
                return units;
            }
        }

        public Unit Save(Unit unit)
        {
            throw new NotImplementedException();
        }
    }
}
