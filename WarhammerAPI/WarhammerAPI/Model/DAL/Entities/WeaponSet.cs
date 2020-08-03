using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerAPI.Model.DAL.Entities
{
    public class WeaponSet
    {
        [Key]
        public int Id { get; set; }
        public WargearSetUp WargearSetUp { get; set; }
        public List<Weapon> Weapon { get; set; }
        //public int Limit { get; set; }
        //public int number { get; set; }
        public bool BuildIn { get; set; }//must be 
    }
}
