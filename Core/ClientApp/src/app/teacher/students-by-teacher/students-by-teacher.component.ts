import { Component, OnInit } from '@angular/core';
import { TeacherService } from '../teacher.service';
import { StudentByTeacher } from './student-node/StudentByTeacher';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-students-by-teacher',
  templateUrl: './students-by-teacher.component.html',
  styleUrls: ['./students-by-teacher.component.css']
})
export class StudentsByTeacherComponent implements OnInit {

  students$: Observable<StudentByTeacher[]>;
  students:StudentByTeacher[]; 

  constructor(private teacherService: TeacherService) { }

  ngOnInit() {
    this.students$ = this.teacherService.getStudentByTeacherIdObservable(2);
    this.students$.subscribe(x => {this.students = x;});
  }

}
