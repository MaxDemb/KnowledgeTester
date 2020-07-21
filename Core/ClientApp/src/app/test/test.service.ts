import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TestNode } from './TestNode';
import { NumberValueAccessor } from '@angular/forms';
import { TestModel } from './TestModel';

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

  postNewTest(model: TestModel){
    return this.http.post<TestNode>(this.baseUrl + 'api/test/new', model);//.pipe(catchError(this.handleError('addHero', hero));
  }

  getAllTestsObservable(){
    return this.http.get<TestNode[]>(this.baseUrl + 'api/test/all');
  }

  // getNewTest(name: String){
  //    this.http.get(this.baseUrl + 'api/test/getByModel', name);
  // }

}
