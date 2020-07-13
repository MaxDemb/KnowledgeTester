import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { TestNode } from '../TestNode';
import { ActivatedRoute } from '@angular/router';
import { TestService } from '../test.service';

@Component({
  selector: 'app-test-teacher',
  templateUrl: './test-teacher.component.html',
  styleUrls: ['./test-teacher.component.css']
})
export class TestTeacherComponent implements OnInit {

  id:number;
  test$: Observable<TestNode>;
  test:TestNode;  

  passed$:Observable<boolean>;
  passed:boolean;

  canSeeResult:boolean;
  constructor(private activateRoute: ActivatedRoute, private testService: TestService) { }

  
  
  ngOnInit() {    
    this.activateRoute.params.subscribe(params=>this.id=params['id']);

    this.test$ = this.testService.getTestObservable(this.id);
    this.test$.subscribe(x => this.test = x);

    
    // this.passed$ = this.testService.isPassedObservable(this.studentId, this.id);
    // this.passed$.subscribe(x => this.passed = x);


    // if(this.passed && this.test.isOpen)
    // {
    //   this.canPass = true;
    //   this.canSeeResults = false;
    // }
  }
}
