using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarhammerAPI.Model.DAL.Entities;

namespace WarhammerAPI.Model.DAL.EF
{
    public class TestData
    {
        public void Start()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (db.Unit.Any() == false)
                {
                    Unit unit = new Unit() { Name = "Canoptek Scarabs" };
                    Models models = new Models()
                    {
                        BS = 0,
                        WS = 4,
                        Move = 10,
                        Strength = 3,
                        Toughness = 3,
                        Attack = 4,
                        Leadership = 10,
                        Save = 6,
                        Cost = 13,
                        Name = "Canoptek Scarab Swarm",
                        Unit = unit
                    };
                    List<Models> modelsL = new List<Models>();
                    modelsL.Add(models);
                    unit.Models = modelsL;
                    unit.UnitType = new UnitType()
                    {
                        Type = "Fast Attack",
                        Unit = unit
                    };
                    unit.UnitNumber = new UnitNumber()
                    {
                        NumberMin = 3,
                        NumberMax = 9,
                        PowerPoints = 2,
                        PowerPointsMax = 6,
                        Unic = false,
                        Unit = unit
                    };
                    //abilities
                    AbilitiesWeapon abilitiesWeapon = new AbilitiesWeapon()
                    {
                        Description = "If the target’s Toughness is higher than this attack’s Strength, this weapon always wounds the target on a wound roll of 5+.",
                        Name = "",
                        Faction="Necron"
                    };
                    ////Weapon
                    Weapon weapon = new Weapon()
                    {
                        Name = "Feeder mandibles",
                        Range = "Melee",
                        Type = "Melee",
                        Strength = "User",
                        AP = "0",
                        Damage = "1",
                        Cost = 0,
                        Relic = false,
                        Faction="Necron"
                    };
                    AddWargearOptions(AddWargearSetUp(AddWeaponSet(AddWeapon(weapon, AddAbilitiesWeapon(abilitiesWeapon)))), unit);
                    db.Unit.Add(unit);

                    db.SaveChanges();
                }
            }
        }
        public void AddWargearOptions(List<WargearSetUp> wargearSetUps, Unit unit)
        {
            WargearOptions wargearOptions = new WargearOptions();
            wargearOptions.WargearSet = wargearSetUps;
            List<WargearOptions> wargearOptionsList = new List<WargearOptions>();
            wargearOptionsList.Add(wargearOptions);
            unit.WargearOptions = wargearOptionsList;
        }
        public List<WargearSetUp> AddWargearSetUp(List<WeaponSet> weaponSets)
        {
            WargearSetUp wargearSetUp = new WargearSetUp();
            wargearSetUp.WeaponSet = weaponSets;
            List<WargearSetUp> wargearSetUps = new List<WargearSetUp>();
            wargearSetUps.Add(wargearSetUp);
            return wargearSetUps;
        }
        public List<WeaponSet> AddWeaponSet(List<Weapon> Weapons)
        {
            WeaponSet weaponSet = new WeaponSet();
            weaponSet.Weapon = Weapons;
            List<WeaponSet> weaponSets = new List<WeaponSet>();
            weaponSets.Add(weaponSet);
            return weaponSets;
        }
        public List<Weapon> AddWeapon(Weapon Weapon, List<AbilitiesWeapon> abilities = null)
        {
            Weapon weapon = Weapon;
            weapon.AbilitiesWeapon = abilities;
            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(weapon);
            return weapons;
        }
        public List<Weapon> AddWeapon(string Name, string Range, string Type, string Strength,string AP, string Damage, int Cost, string Faction, bool Relic=false, List<AbilitiesWeapon> abilities=null)
        {
            Weapon weapon = new Weapon()
            {
                Name = Name,
                Range = Range,
                Type = Type,
                Strength = Strength,
                AP = AP,
                Damage = Damage,
                Cost = Cost,
                Relic = Relic,
                Faction=Faction
            };
            weapon.AbilitiesWeapon = abilities;
            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(weapon);
            return weapons;
        }
        public List<AbilitiesWeapon> AddAbilitiesWeapon(AbilitiesWeapon AbilitiesWeapon)
        {
            List<AbilitiesWeapon> abilities = new List<AbilitiesWeapon>();
            AbilitiesWeapon abilitiesWeapon = AbilitiesWeapon;
            abilities.Add(abilitiesWeapon);
            return abilities;
        }
        public List<AbilitiesWeapon> AddAbilitiesWeapon(string Description, string name = "", string Faction = "")
        {
            List<AbilitiesWeapon> abilities = new List<AbilitiesWeapon>();
            AbilitiesWeapon abilitiesWeapon = new AbilitiesWeapon()
            {
                Description = Description,
                Name = name,
                Faction = Faction
            };
            abilities.Add(abilitiesWeapon);
            return abilities;
        }

    }
}
