import { Injectable, Inject } from '@angular/core';
import { resultModel } from './resultModel';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ResultService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  createResult(result: resultModel){
    return this.http.post<resultModel>(this.baseUrl + 'api/Result/add', result);
  }

  updateResult(result: resultModel){
    return this.http.put(this.baseUrl + 'api/Result/update', result);
  }

  resultExist(result: resultModel){
    return this.http.post<resultModel>(this.baseUrl + 'api/Result/exist', result);
  }
}

