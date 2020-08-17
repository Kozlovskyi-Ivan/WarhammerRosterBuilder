import { AbilitiesWeapon } from './AbilitiesWeapon';
import { WeaponSet } from './WeaponSet';
export class Weapon {
  public faction?: string;
  public name?: string;
  public range?: string;
  public type?: string;
  public strength?: string;
  public ap?: string; // Armour Penetration
  public damage?: string;
  public cost?: number;
  public relic?: boolean;
  public weaponSet?: WeaponSet;
  public abilitiesWeapon?: AbilitiesWeapon[];
}
