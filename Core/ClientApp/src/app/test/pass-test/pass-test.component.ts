import { Component, OnInit } from '@angular/core';
import { QuestionService } from '../../question/question.service';
import { Observable } from 'rxjs';
import { questionModel } from '../../question/questionModel';

@Component({
  selector: 'app-pass-test',
  templateUrl: './pass-test.component.html',
  styleUrls: ['./pass-test.component.css']
})
export class PassTestComponent implements OnInit {

  testName : string;
  
  testId : number;

  questions$: Observable<questionModel[]>;
  questions : questionModel[];

  constructor(private questionService: QuestionService) { }

  ngOnInit() {
    this.testName = localStorage.getItem('testPassName');
    this.testId = Number(localStorage.getItem('testPassId'));

    console.log(this.testId);

    this.questions$ = this.questionService.getQuestionsByTestIdObservable(this.testId);
    this.questions$.subscribe(res =>{
        console.log(res);
        this.questions = res;
      });
    setTimeout(()=>{
      console.log(this.questions);
    },3000);
  }

}
