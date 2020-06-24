import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TestNode } from './test-for-student/TestNode';
import { NumberValueAccessor } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class TestService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  

  getTestObservable(id:number){
    return this.http.get<TestNode>(this.baseUrl + 'api/tests/1/test');
  }

  isPassedObservable(studentId:number, testId:number){
    return this.http.get<boolean>(this.baseUrl + 'api/students/1/passed/1');
  }

}
