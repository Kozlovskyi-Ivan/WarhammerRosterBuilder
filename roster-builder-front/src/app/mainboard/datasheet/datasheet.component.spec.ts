/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { DatasheetComponent } from './datasheet.component';

describe('DatasheetComponent', () => {
  let component: DatasheetComponent;
  let fixture: ComponentFixture<DatasheetComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DatasheetComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DatasheetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
