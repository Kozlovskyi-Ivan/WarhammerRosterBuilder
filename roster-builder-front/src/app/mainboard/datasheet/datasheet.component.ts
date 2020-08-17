import { Weapon } from './../../Entities/Weapon';
import { UnitService } from './../../unit.service';
import { Unit } from './../../Entities/Unit';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
// import { Subscription } from 'rxjs/internal/Subscription';
@Component({
  selector: 'app-datasheet',
  templateUrl: './datasheet.component.html',
  styleUrls: ['./datasheet.component.css']
})
export class DatasheetComponent implements OnInit {

  private Unit?: Unit;
  private name: string;
  constructor(
    private route: ActivatedRoute,
    private UnitService: UnitService,
    private location: Location,
    // private subscription: Subscription

  ) { }

  ngOnInit() {
    this.getUnit();
  }

  getUnit() {
    this.name=this.route.snapshot.params['name'];
    this.UnitService.getHero(this.name).subscribe((unit:Unit)=>this.Unit=unit);
  }

}
