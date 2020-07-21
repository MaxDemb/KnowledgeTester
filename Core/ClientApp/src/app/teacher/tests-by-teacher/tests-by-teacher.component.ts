import { Component, OnInit, Input } from '@angular/core';
import { TeacherService } from '../teacher.service';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

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

  constructor(private teacherService: TeacherService, private router: Router) { }

  ngOnInit() {
    console.log(this.name);
    console.log(this.openedDate);
  }

  watchResult(){
    localStorage.setItem('testIdResult', String(this.id));
    localStorage.setItem('testNameResult', String(this.name));
    setTimeout(()=>{
      this.router.navigateByUrl('/results');
    },300);
  }
}
