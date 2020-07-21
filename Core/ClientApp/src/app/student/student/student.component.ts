import { Component, OnInit } from '@angular/core';
import { StudentServiceService } from '../student-service.service';
import { Observable, TeardownLogic } from 'rxjs';
import { Student } from './students';
import { Teacher } from '../../teacher/teacher/teacher';
import { TestNode } from '../../test/TestNode';
import { TeacherService } from '../../teacher/teacher.service';
import { TestService } from '../../test/test.service';
import { resultModel } from '../../results/resultModel';
import { ResultService } from '../../results/result.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  student$: Observable<Student>;
  student: Student;

  id:number;

  teacher$: Observable<Teacher>;
  teacher: Teacher;
  tests$: Observable<TestNode[]>;
  tests:TestNode[];

  isTests:boolean = true;

  constructor(private studentService: StudentServiceService, private testService: TestService,
     private resultService: ResultService, private router:Router) { }

  ngOnInit() {

    this.id = Number(localStorage.getItem('id'));

    this.student$ = this.studentService.getStudentObservable(this.id);
    this.student$.subscribe(x => {this.student = x;});
    this.tests$ = this.testService.getAllTestsObservable();
    this.tests$.subscribe( res =>{
      this.tests = res;
    });
    setTimeout(() => 
    {
      console.log(this.student.id);
      console.log(this.tests.length);
    },
    1000);

  //  this.tests$ = this.testService.getTestObservable(this.student.id);
    
  }

  showTests()
  {
    this.isTests = !this.isTests;
  }
  testExists(){
    return this.tests.length;
  }

 

}
