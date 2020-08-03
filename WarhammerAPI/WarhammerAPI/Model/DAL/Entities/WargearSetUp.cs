using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerAPI.Model.DAL.Entities
{
    public class WargearSetUp
    {
        [Key]
        public int Id { get; set; }
        public WargearOptions WargearOption { get; set; }
        public List<WeaponSet> WeaponSet { get; set; }
        //public int Limit { get; set; }
        //public bool BuildIn { get; set; }//must be 
    }
}
