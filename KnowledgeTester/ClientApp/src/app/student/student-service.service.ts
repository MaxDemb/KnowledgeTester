import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Student } from './student/students';
import { Teacher } from '../teacher/teacher/teacher';
import { TestNode } from '../test/test-for-student/TestNode';

@Injectable({
  providedIn: 'root'
})


export class StudentServiceService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }
  
  getStudentObservable(id:number){
    return this.http.get<Student>(this.baseUrl + 'api/students/' + id + '/student');
  }

  getTeacherByStudentObservable(id:number){
    return this.http.get<Teacher>(this.baseUrl + 'api/students/' + id + '/teacher');
  }

  getTestsByStudentObservable(id:number){
    return this.http.get<TestNode>(this.baseUrl + 'api/students/' + id + '/tests');
  }

}
