using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerAPI.Model.DAL.Entities
{
    public class FractionKeywords
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Unit Unit { get; set; }

    }
}
