import { Component, OnInit, Input } from '@angular/core';
import { TeacherService } from '../../teacher/teacher.service';
import { Router } from '@angular/router';
import { resultModel } from '../../results/resultModel';
import { Observable } from 'rxjs';
import { ResultService } from '../../results/result.service';

@Component({
  selector: 'app-test-student',
  templateUrl: './test-student.component.html',
  styleUrls: ['./test-student.component.css']
})
export class TestStudentComponent implements OnInit {
  
  @Input() id:number;
  @Input() name:string;
  @Input() isOpen:boolean;
  @Input() openedDate:Date;
  @Input() deadline:Date;


  result:resultModel;
  resultFromBack$:Observable<resultModel>;
  resultFromBack:resultModel;
  triedToPass:boolean;

  resultCalculated:boolean;
  constructor(private teacherService: TeacherService, private router: Router, private resultService: ResultService) { }

  ngOnInit() {
    this.resultCalculated = false;

    this.result = {
      id : 0,
      name : 'RandomName',
      rightAnswers : 0,
      testId : this.id,
      studentId : Number(localStorage.getItem('id'))
    }
    this.resultFromBack$ = this.resultService.resultExist(this.result);
    this.resultFromBack$.subscribe(res=>{
      this.resultFromBack = res;
    });


    setTimeout(()=>{
      this.triedToPass = this.TriedToPass();
      this.resultCalculated = true;
    },1000);
  }


  passTest(){
    localStorage.setItem('testPassId', String(this.id));
    localStorage.setItem('testPassName', this.name);
    setTimeout(()=>{
      this.router.navigate(['/pass-test']);
    },300);
  }

  TriedToPass():boolean{
    
      console.log(this.resultFromBack);
      if(this.resultFromBack != undefined && this.resultFromBack != null){
        return true;
      }
      else {
        return false;
      }
  }
}
