import { Component, OnInit } from '@angular/core';
import { QuestionService } from '../../question/question.service';
import { Observable } from 'rxjs';
import { questionSecure } from '../../question/questionSecure';
import { ResultService } from '../../results/result.service';
import { resultModel } from '../../results/resultModel';
import { NumberValueAccessor } from '@angular/forms';
import { Router } from '@angular/router';
import { TestService } from '../test.service';

@Component({
  selector: 'app-pass-test',
  templateUrl: './pass-test.component.html',
  styleUrls: ['./pass-test.component.css']
})
export class PassTestComponent implements OnInit {

  testName : string;
  
  testId : number;
  studentId : number;

  questions$: Observable<questionSecure[]>;
  questions : questionSecure[];

  result: resultModel;

  resultFromBack$: Observable<resultModel>;
  resultFromBack: resultModel;

  constructor(private questionService: QuestionService, private testService:TestService,
     private resultService: ResultService, private router: Router) { }

  ngOnInit() {
    this.alreadyPassedGuard();
    // this.testName = localStorage.getItem('testPassName');
    // this.testId = Number(localStorage.getItem('testPassId'));
    // this.studentId = Number(localStorage.getItem('id'));
    localStorage.setItem('RightAnswers', String(0));
    localStorage.setItem('answers', String(0));
   

    console.log(this.result);
    
    
    this.questions$ = this.questionService.getQuestionsByTestIdObservable(this.testId); 
    this.questions$.subscribe(res =>{
        this.questions = res;
      });
  }

  stopTest(){
    
    this.result.rightAnswers =  Number(localStorage.getItem('RightAnswers'));
    console.log(this.result);
    localStorage.removeItem('testPassName');
    localStorage.removeItem('testPassId');  
    localStorage.removeItem('RightAnswers');
    localStorage.removeItem('answers');
    
    this.resultFromBack$ = this.resultService.createResult(this.result);
    this.resultFromBack$.subscribe(res => this.resultFromBack = res);
    setTimeout(()=>{
      this.router.navigateByUrl('/student');
    }, 1000);
  }

  alreadyPassedGuard(){
    
    this.testName = localStorage.getItem('testPassName');
    this.testId = Number(localStorage.getItem('testPassId'));
    this.studentId = Number(localStorage.getItem('id'));

    this.result = {
      id : 0,
      passed: false,
      name : 'RandomName',
      rightAnswers : 0,
      testId : this.testId,
      studentId : this.studentId
    }
    if(this.testName == null){
      this.router.navigateByUrl("/student");
    }
    
    this.resultFromBack$ = this.resultService.resultExist(this.result);
    this.resultFromBack$.subscribe(res=>{
      this.resultFromBack = res;
    });

    setTimeout(()=>{
      if(this.resultFromBack != undefined && this.resultFromBack != null){
        this.router.navigateByUrl("/student");
      }
    }, 300);
  }


}
