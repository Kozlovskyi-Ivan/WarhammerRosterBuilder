using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerAPI.Model.DAL.Entities
{
    public class UnitType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public Unit Unit { get; set; }
    }
}
