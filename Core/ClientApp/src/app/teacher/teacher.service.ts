import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Teacher } from './teacher/teacher';
import { TestNode } from '../test/TestNode';

@Injectable({
  providedIn: 'root'
})
export class TeacherService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getTeacherObservable(id : number){
    return this.http.get<Teacher>(this.baseUrl + 'api/teachers/' + id + '/teacher');
  }

  getTestsByTeacherIdObservable(id : number){
    return this.http.get<TestNode[]>(this.baseUrl + 'api/teachers/' + id + '/tests');
  }

}
