import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UserModel} from './User';

@Injectable({
  providedIn: 'root'
})

export class UserService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }


  RegistrateUser(model:UserModel){
    return this.http.post(this.baseUrl + 'api/user/register', model);
  }
}
