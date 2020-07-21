import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { questionModel} from './questionModel';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  addQuestion(questionFromFront:questionModel){
    return this.http.post<questionModel>(this.baseUrl + 'api/Question/new', questionFromFront);
  }

  getQuestionsByTestIdObservable(id: number){
    return this.http.get<questionModel[]>(this.baseUrl + 'api/Questions/getByTestId/'+ id);
  }
}
