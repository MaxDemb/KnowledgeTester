import { Component, OnInit } from '@angular/core';
import { QuestionService } from '../question.service';
import { VariantModel } from '../../variants/variantModel';
import { VariantService} from '../../variants/variant.service';
import { questionModel} from '../questionModel';
import { Observable, interval } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-question',
  templateUrl: './create-question.component.html',
  styleUrls: ['./create-question.component.css']
})
export class CreateQuestionComponent implements OnInit {


  questionNumber : number;
  testName: string;

  questionName: string;
  
  questionFromBack$: Observable<questionModel>;
  questionFromBack: questionModel;
  newId: number;

  variant1: string;
  variant2: string;
  variant3: string;
  variant4: string;
  variant1model: VariantModel;
  variant2model: VariantModel;
  variant3model: VariantModel;
  variant4model: VariantModel;


  radio:any;
  question: questionModel;
  

  constructor(private questionService: QuestionService, private variantService: VariantService, private router: Router) { }

  ngOnInit() {
    this.questionNumber = Number(localStorage.getItem('currentQuestion')),
    this.testName = localStorage.getItem('testName');
  }

 
  cancel(){
    localStorage.removeItem('testName');
    localStorage.removeItem('currentQuestion');

    setTimeout(()=>
      {
        this.router.navigateByUrl('/teacher');
      },300);
  }

  submit(){
    this.createQuestionObject();
    console.log(this.question);
    
    this.questionFromBack$ = this.questionService.addQuestion(this.question);
    this.questionFromBack$.subscribe(
    res => {
      this.questionFromBack = res;
    });
    interval(1000);
    setTimeout(() => 
    {
      console.log(this.questionFromBack);
      this.createVariantObjects(this.questionFromBack.id);
      console.log(this.variant1model);
      console.log(this.variant2model);
      console.log(this.variant3model);
      console.log(this.variant4model);
      this.variantService.addVariant(this.variant1model).subscribe();
      this.variantService.addVariant(this.variant2model).subscribe();
      this.variantService.addVariant(this.variant3model).subscribe();
      this.variantService.addVariant(this.variant4model).subscribe();
      localStorage.setItem('currentQuestion', String(this.questionNumber + 1));
      setTimeout(()=>
      {
        this.router.navigateByUrl('/create-test');
      },300);
    },
    300);
    

    
  }


  createVariantObjects(newQuestionId:number){

    this.variant1model = {
      Name : this.variant1,
      Right : false,
      QuestionId : newQuestionId
    };
    this.variant2model = {
      Name : this.variant2,
      Right : false,
      QuestionId : newQuestionId
    }
    this.variant3model = {
      Name : this.variant3,
      Right : false,
      QuestionId : newQuestionId
    }
    this.variant4model = {
      Name : this.variant4,
      Right : false,
      QuestionId : newQuestionId
    }
    

    if(this.radio == 1){
      this.variant1model.Right = true;
    }else if(this.radio == 2){
      this.variant2model.Right = true;
    }else if(this.radio == 3){
      this.variant3model.Right = true;
    }else if(this.radio == 4){
      this.variant4model.Right = true;
    }
  }

  createQuestionObject(){

    this.question = {
      id : 0,
      name : this.questionName,
      rightAnswer : this.getRightAnswerString(),
      testId : Number(localStorage.getItem('testId'))
    };
  }

  getRightAnswerString(){
    if(this.radio == 1){
      return this.variant1;
    }else if(this.radio == 2){
      return this.variant2;
    }else if(this.radio == 3){
      return this.variant3;
    }else if(this.radio == 4){
      return this.variant4;
    }
  }
}
