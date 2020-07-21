import { Component, OnInit, Input } from '@angular/core';
import { TeacherService } from '../../teacher/teacher.service';
import { Router } from '@angular/router';
import { ResultService } from '../result.service';
import { resultModel } from '../resultModel';
import { Observable } from 'rxjs';
import { questionModel } from '../../question/questionModel';
import { QuestionService } from '../../question/question.service';

@Component({
  selector: 'app-student-by-result',
  templateUrl: './student-by-result.component.html',
  styleUrls: ['./student-by-result.component.css']
})
export class StudentByResultComponent implements OnInit {

 
  @Input() testId:number;
  @Input() studentId:number;
  @Input() studentName:string;
  

  result:resultModel;
  resultFromBack$:Observable<resultModel>;
  resultFromBack:resultModel;

  questions$: Observable<questionSecure[]>;
  questions: questionSecure[];
  triedToPass:boolean;

  resultCalculated:boolean;
  constructor(private teacherService: TeacherService, private questionService:QuestionService, 
    private router: Router, private resultService: ResultService) { }

  ngOnInit() {
    this.resultCalculated = false;
    this.questions$ = this.questionService.getQuestionsByTestIdObservable(this.testId); 
    this.questions$.subscribe(res =>{
        this.questions = res;
      });

    this.result = {
      id : 0,
      name : 'RandomName',
      passed: false,
      rightAnswers : 0,
      testId : this.testId,
      studentId : this.studentId
    }
    this.resultFromBack$ = this.resultService.resultExist(this.result);
    this.resultFromBack$.subscribe(res=>{
      this.resultFromBack = res;
    });


    setTimeout(()=>{
      this.resultCalculated = true;
    },300);
  }

}
