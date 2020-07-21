import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Student } from './student/students';
import { Teacher } from '../teacher/teacher/teacher';
import { TestNode } from '../test/TestNode';

@Injectable({
  providedIn: 'root'
})


export class StudentServiceService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }
  
  getStudentObservable(id:number){
    return this.http.get<Student>(this.baseUrl + 'api/students/' + id + '/student');
  }
  
  getAllStudentsTriedToPassTest(id:number){
    return this.http.get<Student[]>(this.baseUrl + 'api/students/triedTest/'+ id);
  }

}
