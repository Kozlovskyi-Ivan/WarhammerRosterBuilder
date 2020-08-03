using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerAPI.Model.DAL.Entities
{
    public class Models
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Move { get; set; }
        public byte BS { get; set; }
        public byte WS { get; set; }
        public byte Strength { get; set; }
        public byte Toughness { get; set; }
        public byte Attack { get; set; }
        public byte Leadership { get; set; }
        public byte Save { get; set; }
        public int Cost { get; set; }
        public Unit Unit { get; set; }
    }
}
