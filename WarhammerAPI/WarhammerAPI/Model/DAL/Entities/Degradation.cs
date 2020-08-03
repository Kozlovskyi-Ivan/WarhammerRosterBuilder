using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerAPI.Model.DAL.Entities
{
    public class Degradation
    {
        [Key]
        public int Id { get; set; }
        public byte HP { get; set; }
        public byte Move { get; set; }
        public byte BS { get; set; }
        public byte WS { get; set; }
        public byte Strength { get; set; }
        public byte Toughness { get; set; }
        public byte Attack { get; set; }
        public byte Leadership { get; set; }
        public byte Save { get; set; }
        public Unit Unit { get; set; }

    }
}
