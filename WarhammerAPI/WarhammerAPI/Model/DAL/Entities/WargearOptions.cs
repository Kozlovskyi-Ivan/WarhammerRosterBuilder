using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerAPI.Model.DAL.Entities
{
    public class WargearOptions
    {
        [Key]
        public int Id { get; set; }
        public Unit Unit { get; set; }
        public List<WargearSetUp> WargearSet { get; set; }
        public int Limit { get; set; }
        //public bool BuildIn  { get; set; }//must be 

    }
}
