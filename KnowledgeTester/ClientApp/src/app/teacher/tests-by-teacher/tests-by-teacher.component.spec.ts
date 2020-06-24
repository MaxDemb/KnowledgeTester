import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TestsByTeacherComponent } from './tests-by-teacher.component';

describe('TestsByTeacherComponent', () => {
  let component: TestsByTeacherComponent;
  let fixture: ComponentFixture<TestsByTeacherComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TestsByTeacherComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TestsByTeacherComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
