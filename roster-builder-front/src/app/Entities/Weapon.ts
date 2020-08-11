import { AbilitiesWeapon } from './AbilitiesWeapon';
import { WeaponSet } from './WeaponSet';
export class Weapon {
  public Faction: string;
  public Name: string;
  public Range: string;
  public Type: string;
  public Strength: string;
  public AP: string; // Armour Penetration
  public Damage: string;
  public Cost: number;
  public Relic: boolean;
  public WeaponSet: WeaponSet;
  public AbilitiesWeapon: AbilitiesWeapon;
}
