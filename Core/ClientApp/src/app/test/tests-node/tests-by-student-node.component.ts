import { Component, OnInit, Input } from '@angular/core';
import { TestService } from '../test.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-tests-by-student-node',
  templateUrl: './tests-by-student-node.component.html',
  styleUrls: ['./tests-by-student-node.component.css']
})
export class TestsByStudentNodeComponent implements OnInit {

  @Input() id:number;
  @Input() name:string;
  @Input() isOpen:boolean;
  @Input() openedDate:Date;
  @Input() deadline:Date;
  @Input() studentId:number;
  constructor(private testService: TestService) { }

  ngOnInit() {
  }

}
