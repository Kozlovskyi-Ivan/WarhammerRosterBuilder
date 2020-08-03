using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerAPI.Model.DAL.Entities
{
    public class UnitNumber
    {
        [Key]
        public int Id { get; set; }
        public Unit Unit { get; set; }
        public int NumberMin { get; set; }
        public int NumberMax { get; set; }
        public int PowerPoints { get; set; }
        public int PowerPointsMax { get; set; }
        public bool Unic { get; set; }
    }

}
