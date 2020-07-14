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
  user2: any;
  
  role : any;
  
  submit(){
  
    console.log(this.role);
    this.user =  {     
      UserName : this.name,
      Email : this.email,
      Password : this.password,
      Role : this.role
    };
    this.userService.RegistrateUser(this.user).subscribe(res => this.user2 = res);
    console.log("success");
  }
}
