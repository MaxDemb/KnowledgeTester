import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentsByTeacherComponent } from './students-by-teacher.component';

describe('StudentsByTeacherComponent', () => {
  let component: StudentsByTeacherComponent;
  let fixture: ComponentFixture<StudentsByTeacherComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StudentsByTeacherComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StudentsByTeacherComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
