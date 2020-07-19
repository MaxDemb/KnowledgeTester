import { Component, OnInit } from '@angular/core';
import { TestModel} from '../TestModel';
import { from } from 'rxjs';
import { TestService } from '../test.service';
@Component({
  selector: 'app-new-test',
  templateUrl: './new-test.component.html',
  styleUrls: ['./new-test.component.css']
})
export class NewTestComponent implements OnInit {


  name: string;
  
  year_open: number;
  month_open: number;
  day_open:number;
  opened:Date;

  year_closed: number;
  month_closed: number;
  day_closed:number;
  closed:Date;
  


  test : TestModel;
  test2: any;
  somedate : Date;
    
  constructor(private testService: TestService) { }

  ngOnInit() { 
    
   }

  submit(){
    this.opened = new Date();
    this.opened.setFullYear(this.year_open);
    this.opened.setMonth(this.month_open);
    this.opened.setDate(this.day_open);

    this.closed = new Date();
    this.closed.setFullYear(this.year_open);
    this.closed.setMonth(this.month_open);
    this.closed.setDate(this.day_open);


    this.test =  {     
      name : this.name,
      openedDate : this.opened,
      creationDate : new Date(),
      deadline : this.closed,
      ownerId : 1,
      isOpen : true
    };
    console.log(this.test);
    this.testService.postNewTest(this.test).subscribe(res => {this.test2 = res});
    console.log(this.test2);
  }
}
