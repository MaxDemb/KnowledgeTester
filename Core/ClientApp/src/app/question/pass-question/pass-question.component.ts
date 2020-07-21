import { Component, OnInit, Input } from '@angular/core';
import { QuestionService } from '../question.service';
import { VariantService } from '../../variants/variant.service';

@Component({
  selector: 'app-pass-question',
  templateUrl: './pass-question.component.html',
  styleUrls: ['./pass-question.component.css']
})
export class PassQuestionComponent implements OnInit {

  @Input() name : number;
  @Input() id : number;

  constructor(private questionService: QuestionService, private variantService: VariantService) { }

  ngOnInit() {
    console.log(this.name);
    console.log(this.id);
    //this.variantService.getVariantsByTestIdObservable(this.id);
    //this.questionService.getQuestionByTestIdObservable(this.testId).subscribe(res => console.log(res));
    
  }

}
