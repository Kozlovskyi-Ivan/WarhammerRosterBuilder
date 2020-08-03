using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerAPI.Model.DAL.Entities
{
    public class Weapon
    {
        [Key]
        public int Id { get; set; }
        public string Faction { get; set; }
        public string Name { get; set; }
        public string Range { get; set; }
        public string Type { get; set; }
        public string Strength { get; set; }
        public string AP { get; set; }//Armour Penetration
        public string Damage { get; set; }
        public int Cost { get; set; }
        public bool Relic { get; set; }
        public WeaponSet WeaponSet { get; set; }
        public List<AbilitiesWeapon> AbilitiesWeapon { get; set; }
    }
}
