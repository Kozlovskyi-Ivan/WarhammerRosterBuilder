using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerAPI.Model.DAL.Entities
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }
        public UnitType UnitType { get; set; }//hq, elite ....
        public string Faction { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Models> Models { get; set; }
        public List<WargearOptions> WargearOptions { get; set; }
        public UnitNumber UnitNumber { get; set; }
        public bool Character { get; set; }
        public List<Abilities> Abilities { get; set; }
        //public List<Weapon> Wargear { get; set; }
        public List<Degradation> Degradation { get; set; }
        //public int RoleId { get; set; }
        public Role Role { get; set; }
        public List<FractionKeywords> FractionKeywords { get; set; }
        public List<Keywords> Keywords { get; set; }
        public WarlordTrait WarlordTrait { get; set; }
        public bool Relic { get; set; }
    }
}
