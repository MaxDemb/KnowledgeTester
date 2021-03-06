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

  login(model: UserModel){
    return this.http.post(this.baseUrl + 'api/user/login', model);
  }

  getUserProfile(){
    return this.http.get(this.baseUrl + 'api/UserProfile');
  }

  
  roleMatch(allowedRoles): boolean {
    var isMatch = false;
    var payLoad = JSON.parse(window.atob(localStorage.getItem('token').split('.')[1]));
    var userRole = payLoad.role;
    allowedRoles.forEach(element => {
      if (userRole == element) {
        isMatch = true;
        return false;
      }
    });
    return isMatch;
  }
}
