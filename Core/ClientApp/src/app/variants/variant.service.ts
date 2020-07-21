import { Injectable, Inject } from '@angular/core';
import { VariantModel } from './variantModel';
import { HttpClient } from '@angular/common/http';
import { questionSecure } from '../question/questionSecure';
import { variantSecure } from './variantSecure';

@Injectable({
  providedIn: 'root'
})
export class VariantService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  addVariant(variantModel : VariantModel){
    return this.http.post(this.baseUrl + 'api/answerVariant/new', variantModel);
  }

  getVariantsByQuestionIdObservable(id : number){
    return this.http.get<variantSecure[]>(this.baseUrl + 'api/answerVariant/getByQuestionId/' + id);
  }

}
