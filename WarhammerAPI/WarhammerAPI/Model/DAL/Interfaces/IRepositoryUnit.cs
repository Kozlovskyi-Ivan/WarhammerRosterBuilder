using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarhammerAPI.Model.DAL.Entities;

namespace WarhammerAPI.Model.DAL.Interfaces
{
    interface IRepositoryUnit
    {
        public Unit FindByName(string Name);
        public List<Unit> GetAll();
        public Unit Save(Unit unit);


    }
}
