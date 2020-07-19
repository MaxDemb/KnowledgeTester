import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TestsByStudentNodeComponent } from './tests-by-student-node.component';

describe('TestsByStudentNodeComponent', () => {
  let component: TestsByStudentNodeComponent;
  let fixture: ComponentFixture<TestsByStudentNodeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TestsByStudentNodeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TestsByStudentNodeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
