import { Component, OnInit, Input } from '@angular/core';
import { TeacherService } from '../../teacher/teacher.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-test-student',
  templateUrl: './test-student.component.html',
  styleUrls: ['./test-student.component.css']
})
export class TestStudentComponent implements OnInit {
  
  @Input() id:number;
  @Input() name:string;
  @Input() isOpen:boolean;
  @Input() openedDate:Date;
  @Input() deadline:Date;

  constructor(private teacherService: TeacherService, private router: Router) { }

  ngOnInit() {
  }


  passTest(){
    localStorage.setItem('testPassId', String(this.id));
    localStorage.setItem('testPassName', this.name);
    localStorage.setItem('questionPassNumber', String(1));
    setTimeout(()=>{
      
      this.router.navigate(['/pass-test']);
    },300);
  }

}
