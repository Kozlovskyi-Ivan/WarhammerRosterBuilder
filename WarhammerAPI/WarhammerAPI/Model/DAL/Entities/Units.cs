using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerAPI.Model.DAL.Entities
{
    //public class Role
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Faction { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public int Limit { get; set; }
    //    public List<SpecialAbilities> SpecialAbilities { get; set; }
    //    public Unit Unit { get; set; }
    //}
    //public class SpecialAbilities
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Faction { get; set; }
    //    public string Type { get; set; }
    //    public string SubType { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public Role Role { get; set; }
    //}
    //public class Models
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public byte Move { get; set; }
    //    public byte BS { get; set; }
    //    public byte WS { get; set; }
    //    public byte Strength { get; set; }
    //    public byte Toughness { get; set; }
    //    public byte Attack { get; set; }
    //    public byte Leadership { get; set; }
    //    public byte Save { get; set; }
    //    public int Cost { get; set; }
    //    public Unit Unit { get; set; }
    //}
    //public class Unit
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public UnitType UnitType { get; set; }//hq, elite ....
    //    public string Faction { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public List<Models> Models { get; set; }
    //    public List<WargearOptions> WargearOptions { get; set; }
    //    public UnitNumber UnitNumber { get; set; }
    //    public bool Character { get; set; }
    //    public List<Abilities> Abilities { get; set; }
    //    //public List<Weapon> Wargear { get; set; }
    //    public List<Degradation> Degradation { get; set; }
    //    //public int RoleId { get; set; }
    //    public Role Role { get; set; }
    //    public List<FractionKeywords> FractionKeywords { get; set; }
    //    public List<Keywords> Keywords { get; set; }
    //    public WarlordTrait WarlordTrait { get; set; }
    //    public bool Relic { get; set; }
    //}

    //public class UnitNumber
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public Unit Unit { get; set; }
    //    public int NumberMin { get; set; }
    //    public int NumberMax { get; set; }
    //    public int PowerPoints { get; set; }
    //    public int PowerPointsMax { get; set; }
    //    public int Unic { get; set; }
    //}

    //public class UnitType
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Type { get; set; }
    //    public Unit Unit { get; set; }
    //}

    //public class WarlordTrait
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Faction { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public Models ModelMustHave { get; set; }
    //}

    //public class Degradation
    //{   
    //    [Key]
    //    public int Id { get; set; }
    //    public byte HP { get; set; }
    //    public byte Move { get; set; }
    //    public byte BS { get; set; }
    //    public byte WS { get; set; }
    //    public byte Strength { get; set; }
    //    public byte Toughness { get; set; }
    //    public byte Attack { get; set; }
    //    public byte Leadership { get; set; }
    //    public byte Save { get; set; }
    //    public Unit Unit { get; set; }

    //}
    //public class FractionKeywords
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public Unit Unit { get; set; }

    //}
    //public class Keywords
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public Unit Unit { get; set; }
    //}
    //public class WargearOptions
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public Unit Unit { get; set; }
    //    public List<WargearSetUp> WargearSet { get; set; }
    //    public int Limit { get; set; }
    //    //public bool BuildIn  { get; set; }//must be 

    //}
    //public class WargearSetUp
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public WargearOptions WargearOption { get; set; }
    //    public List<WeaponSet> WeaponSet { get; set; }
    //    //public int Limit { get; set; }
    //    //public bool BuildIn { get; set; }//must be 
    //}
    //public class WeaponSet
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public WargearSetUp WargearSetUp { get; set; }
    //    public List<Weapon> Weapon { get; set; }
    //    //public int Limit { get; set; }
    //    //public int number { get; set; }
    //    public bool BuildIn { get; set; }//must be 
    //}
    //public class Weapon
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Faction { get; set; }
    //    public string Name { get; set; }
    //    public string Range { get; set; }
    //    public string Type { get; set; }
    //    public string Strength { get; set; }
    //    public string AP { get; set; }//Armour Penetration
    //    public string Damage { get; set; }
    //    public int Cost { get; set; }
    //    public bool Relic { get; set; }
    //    public WeaponSet WeaponSet { get; set; }
    //    public List<AbilitiesWeapon> AbilitiesWeapon { get; set; }
    //}
    //public class AbilitiesWeapon
    //{
    //    public Weapon Weapon { get; set; }
    //    [Key]
    //    public int Id { get; set; }
    //    public string Faction { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //}
    //public class Abilities
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Faction { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public bool Relic { get; set; }
    //    public int Cost { get; set; }
    //    public Unit Unit { get; set; }

    //}
}
