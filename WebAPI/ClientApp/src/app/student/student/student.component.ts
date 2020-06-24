import { Component, OnInit } from '@angular/core';
import { StudentServiceService } from '../student-service.service';
import { Observable, TeardownLogic } from 'rxjs';
import { Student } from './students';
import { Teacher } from 'src/app/teacher/teacher/teacher';
import { TestNode } from 'src/app/test/test-for-student/TestNode';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  student$: Observable<Student>;
  student: Student;
  teacher$: Observable<Teacher>;
  teacher: Teacher;
  test$: Observable<TestNode>;
  tests:TestNode;

  isTests:boolean = false;

  constructor(private studentService: StudentServiceService) { }

  ngOnInit() {
    this.student$ = this.studentService.getStudentObservable(2);
    this.student$.subscribe(x => {this.student = x;});
    this.teacher$ = this.studentService.getTeacherByStudentObservable(2);
    this.teacher$.subscribe(x => {this.teacher = x;});
    this.test$ = this.studentService.getTestsByStudentObservable(2);
    this.test$.subscribe(x => {this.tests = x;});
    
  }

  showTests()
  {
    this.isTests = !this.isTests;
  }

}
