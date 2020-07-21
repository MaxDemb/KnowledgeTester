import { Component, OnInit, Input } from '@angular/core';
import { QuestionService } from '../question.service';
import { VariantService } from '../../variants/variant.service';
import { Observable } from 'rxjs';
import { questionSecure } from '../questionSecure';
import { variantSecure } from '../../variants/variantSecure';
import { VariantModel } from '../../variants/variantModel';

@Component({
  selector: 'app-pass-question',
  templateUrl: './pass-question.component.html',
  styleUrls: ['./pass-question.component.css']
})
export class PassQuestionComponent implements OnInit {

  @Input() name : number;
  @Input() id : number;

  answered:boolean;

  variants$ : Observable<variantSecure[]>;
  variants : variantSecure[];

  answer$ : Observable<VariantModel>;
  answer: VariantModel;

  answerNum: number;

  rightAnswer: boolean;
  constructor(private questionService: QuestionService, private variantService: VariantService) { }

  ngOnInit() {
    this.answered = false;
    
    this.variants$ = this.variantService.getVariantsByQuestionIdObservable(this.id);
    this.variants$.subscribe(res =>{
      //console.log(res);
      this.variants = res;
    });

    setTimeout(()=>{
      console.log(this.variants);
    },2000);

    //this.questionService.getQuestionByTestIdObservable(this.testId).subscribe(res => console.log(res));
    
  }

  validateResult(){
    var answers = Number(localStorage.getItem('answers'));
    answers++;
    localStorage.setItem('answers',String(answers));

    this.answered = true;
    if(this.answer.right){
      var rightAnswers = Number(localStorage.getItem('RightAnswers'));
      rightAnswers++;
      this.rightAnswer = true;
      localStorage.setItem('RightAnswers', String(rightAnswers));
    }
    else{
      this.rightAnswer = false;
    }
  }

  submit(){
   // console.log(this.variants[this.answerNum - 1]);
    this.answer$ = this.questionService.sendAnswer(this.variants[this.answerNum - 1]);
    this.answer$.subscribe(res => 
      { 
        this.answer = res;
      });
    setTimeout(()=>{
      this.validateResult();
    },300);

  }
}
