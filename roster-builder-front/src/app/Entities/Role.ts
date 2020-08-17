import { Unit } from './Unit';
import { SpecialAbilities } from './SpecialAbilities';

export class Role {
  public faction?: string;
  public name?: string;
  public description?: string;
  public limit?: number;
  public specialAbilities?: SpecialAbilities[];
  public unit?: Unit;
}
