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
  
  test : TestModel;
  test2: any;

  constructor(private testService: TestService) { }

  ngOnInit() {  }

  submit(){
    this.test =  {     
      name : this.name,
      openedDate : new Date(),
      creationDate : new Date(),
      deadline : new Date(),
      ownerId : 1,
      isOpen : true
    };
    
    this.testService.postNewTest(this.test).subscribe(res => {this.test2 = res});
    console.log(this.test2);
    console.log("success");
  }
}
