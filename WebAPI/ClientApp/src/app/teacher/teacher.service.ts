import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Teacher } from './teacher/teacher';
import { StudentByTeacher } from './students-by-teacher/student-node/StudentByTeacher';
import { TestNode } from '../test/test-for-student/TestNode';

@Injectable({
  providedIn: 'root'
})
export class TeacherService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getTeacherObservable(id : number){
    return this.http.get<Teacher>(this.baseUrl + 'api/teachers/' + id + '/teacher');
  }

  getStudentByTeacherIdObservable(id : number){
    return this.http.get<StudentByTeacher[]>(this.baseUrl + 'api/teachers/' + id + '/students');
  }


  getTestsByTeacherIdObservable(id : number){
    return this.http.get<TestNode[]>(this.baseUrl + 'api/teachers/' + id + '/tests');
  }

}
