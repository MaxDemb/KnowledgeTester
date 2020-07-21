import { Component, OnInit } from '@angular/core';
import { Teacher } from './teacher';
import { TeacherService } from '../teacher.service';
import { filter } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { TestNode } from '../../test/TestNode';
import { NumberValueAccessor } from '@angular/forms';
import { Router } from '@angular/router';

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

  id:number;
  
  constructor(private teacherService: TeacherService,  private router: Router) { }

  ngOnInit() {  
    this.id = Number(localStorage.getItem('id'));
    this.teacher$ = this.teacherService.getTeacherObservable(this.id);
    this.teacher$.subscribe(x => {this.teacher = x;});
    
    this.tests$ = this.teacherService.getTestsByTeacherIdObservable(this.id);
    this.tests$.subscribe(x => {this.tests = x; console.log(x);});
    
  }

  showStudents()
  {
    this.isStudents = !this.isStudents;
  }
  showTests(){
    this.isTests = !this.isTests;
  }

  testExists(){
    return this.tests.length;
  }
}
