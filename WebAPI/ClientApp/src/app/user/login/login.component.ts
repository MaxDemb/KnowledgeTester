import { Component, OnInit } from '@angular/core';
import { UserModel } from '../User';
import { UserService } from '../user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private userService: UserService,  private router: Router) { }

  ngOnInit() {
    if (localStorage.getItem('token') != null)
      this.router.navigateByUrl('/student');
  }
  
  name: string;
  email: string;
  password: string;
  user : UserModel;
  user2: any;
  
  role : any;
  
  submit(){
    this.user =  {     
      UserName : this.name,
      Email : this.email,
      Password : this.password,
      Role : this.role
    };
    this.userService.login(this.user).subscribe(
      (res: any) => {
        localStorage.setItem('token', res.token);
        this.router.navigateByUrl('/student');
      },
      err => {
        console.log(err);
      }
    );
    
    
  
  }
}
