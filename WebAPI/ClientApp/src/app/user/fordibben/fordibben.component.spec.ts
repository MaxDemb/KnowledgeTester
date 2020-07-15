import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FordibbenComponent } from './fordibben.component';

describe('FordibbenComponent', () => {
  let component: FordibbenComponent;
  let fixture: ComponentFixture<FordibbenComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FordibbenComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FordibbenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
