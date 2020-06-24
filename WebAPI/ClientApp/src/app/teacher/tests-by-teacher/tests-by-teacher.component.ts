import { Component, OnInit, Input } from '@angular/core';
import { TeacherService } from '../teacher.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-tests-by-teacher',
  templateUrl: './tests-by-teacher.component.html',
  styleUrls: ['./tests-by-teacher.component.css']
})
export class TestsByTeacherComponent implements OnInit {

  @Input() id:number;
  @Input() name:string;
  @Input() isOpen:boolean;
  @Input() openedDate:Date;
  @Input() deadline:Date;

  constructor(private teacherService: TeacherService) { }

  ngOnInit() {
  }

}
