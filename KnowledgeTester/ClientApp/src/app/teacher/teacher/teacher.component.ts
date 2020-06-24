import { Component, OnInit } from '@angular/core';
import { Teacher } from './teacher';
import { TeacherService } from '../teacher.service';
import { filter } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { TestNode } from 'src/app/test/test-for-student/TestNode';

@Component({
  selector: 'app-teacher',
  templateUrl: './teacher.component.html',
  styleUrls: ['./teacher.component.css']
})
export class TeacherComponent implements OnInit {

  teacher$:Observable<Teacher>
  teacher:Teacher;
  isStudents:boolean  = false;
  isTests:boolean = false;
  
  tests$: Observable<TestNode[]>;
  tests: TestNode[]; 
  
  constructor(private teacherService: TeacherService) { }

  ngOnInit() {
    this.teacher$ = this.teacherService.getTeacherObservable(2);
    this.teacher$.subscribe(x => {this.teacher = x;});
    
    this.tests$ = this.teacherService.getTestsByTeacherIdObservable(2);
    this.tests$.subscribe(x => {this.tests = x;});
  
  }

  showStudents()
  {
    this.isStudents = !this.isStudents;
  }
  showTests(){
    this.isTests = !this.isTests;
  }


}
