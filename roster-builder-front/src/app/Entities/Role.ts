import { Unit } from './Unit';
import { SpecialAbilities } from './SpecialAbilities';

export class Role {
  public Faction: string;
  public Name: string;
  public Description: string;
  public Limit: number;
  public SpecialAbilities: SpecialAbilities[];
  public Unit: Unit;
}
