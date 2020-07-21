import { Component, OnInit } from '@angular/core';
import { StudentServiceService } from '../../student/student-service.service';
import { Student } from '../../student/student/students';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-result',
  templateUrl: './result.component.html',
  styleUrls: ['./result.component.css']
})
export class ResultComponent implements OnInit {

  testId:number;
  testName: string;
  students$: Observable<Student[]>;
  students: Student[];
  isCalculated: boolean = false;
  constructor(private studentService: StudentServiceService) { }

  ngOnInit() {
    this.testId = Number(localStorage.getItem('testIdResult'));
    this.testName = localStorage.getItem('testNameResult');
    this.students$ = this.studentService.getAllStudentsTriedToPassTest(this.testId);
    this.students$.subscribe(res =>{
      console.log(res);
      this.students = res;
    });

    setTimeout(()=>{
      console.log(this.students);
      this.isCalculated = true;
    },1000);


  }

}
