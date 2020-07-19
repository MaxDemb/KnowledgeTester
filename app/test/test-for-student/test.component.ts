import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute} from '@angular/router';
import { TestNode } from '../TestNode';
import { Observable } from 'rxjs';
import { TestService } from '../test.service';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  id:number;
  test$: Observable<TestNode>;
  test:TestNode;  
  studentId:number;

  passed$:Observable<boolean>;
  passed:boolean;


  canPass:boolean;

  canSeeResults:boolean;


  constructor(private activateRoute: ActivatedRoute, private testService: TestService) { }

  
  
  ngOnInit() {    
    this.activateRoute.params.subscribe(params=>this.id=params['id']);
    this.activateRoute.params.subscribe(params=>this.studentId=params['studentId']);

    this.test$ = this.testService.getTestObservable(this.id);
    this.test$.subscribe(x => this.test = x);

    
    this.passed$ = this.testService.isPassedObservable(this.studentId, this.id);
    this.passed$.subscribe(x => this.passed = x);


    if(this.passed && this.test.isOpen)
    {
      this.canPass = true;
      this.canSeeResults = false;
    }
  }

}
