using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerAPI.Model.DAL.Entities
{
    public class AbilitiesWeapon
    {
        public Weapon Weapon { get; set; }
        [Key]
        public int Id { get; set; }
        public string Faction { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
