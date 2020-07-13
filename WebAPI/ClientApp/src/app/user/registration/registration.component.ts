import { Component, OnInit } from '@angular/core';
import {NgForm} from '@angular/forms';
import { UserModel } from '../User';
import { UserService } from '../user.service';
@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(private userService: UserService) { }

  ngOnInit() {
  }

  name: string;
  email: string;
  password: string;
  user : UserModel;
  

  submit(){
    this.user =  {     
      Login : this.name,
      Email : this.email,
      Password : this.password
    };
    // this.user.Login = this.name;
    // this.user.Email = this.email;
    // this.user.Password = this.password;
    this.userService.RegistrateUser(this.user);
    console.log("success");
  }
}
