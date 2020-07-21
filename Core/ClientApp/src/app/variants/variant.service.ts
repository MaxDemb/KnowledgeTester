import { Injectable, Inject } from '@angular/core';
import { VariantModel } from './variantModel';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class VariantService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  addVariant(variantModel : VariantModel){
    return this.http.post(this.baseUrl + 'api/answerVariant/new', variantModel);
  }

  getVariantsByTestIdObservable(id : number){
    return this.http.get(this.baseUrl + 'api/answerVariant/getByTestId' + id);
  }

}
