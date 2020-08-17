import { Keywords } from './Keywords';
import { FractionKeywords } from './FractionKeywords';
import { Degradation } from './Degradation';
import { Abilities } from './Abilities';
import { WargearOptions } from './WargearOptions';
import { Models } from './Models';
import { UnitType } from './UnitType';
import { WarlordTrait } from './WarlordTrait';
import { UnitNumber } from './UnitNumber';
import { Role } from './Role';

export class Unit {
  public id?:number;
  public unitType?: UnitType;
  public faction?: string;
  public name?: string;
  public description?: string;
  public models?: Models[];
  public wargearOptions?: WargearOptions[];
  public unitNumber?: UnitNumber;
  public character?: boolean;
  public abilities?: Abilities[];
  public degradation?: Degradation[];
  public role?: Role;
  public fractionKeywords?: FractionKeywords[];
  public keywords?: Keywords[];
  public warlordTrait?: WarlordTrait;
  public relic?: boolean;
}
