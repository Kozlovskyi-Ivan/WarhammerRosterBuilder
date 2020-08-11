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
  public UnitType: UnitType;
  public Faction: string;
  public Name: string;
  public Description: string;
  public Models: Models[];
  public WargearOptions: WargearOptions[];
  public UnitNumber: UnitNumber;
  public Character: boolean;
  public Abilities: Abilities[];
  public  Degradation: Degradation[];
  public Role: Role;
  public FractionKeywords: FractionKeywords[];
  public  Keywords: Keywords[];
  public WarlordTrait: WarlordTrait;
  public Relic: boolean;
}
