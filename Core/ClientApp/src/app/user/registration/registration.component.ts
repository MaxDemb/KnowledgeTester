import { Component, OnInit } from '@angular/core';
import {NgForm} from '@angular/forms';
import { UserModel } from '../User';
import { UserService } from '../user.service';
import { Router } from '@angular/router';
import { Observable } from 'rxjs/internal/Observable';
import { ProfileFromBack } from '../ProfileFromBack';
@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(private userService: UserService,  private router: Router) { }

  ngOnInit() {
  }

  name: string;
  email: string;
  password: string;
  user : UserModel;
  user2: any;
  profile$ :Observable<ProfileFromBack>;
  
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
    setTimeout(() => 
          {
            this.login();
          },
          1000);
  }

  login(){
    this.userService.login(this.user).subscribe(
      (res: any) => {
        localStorage.setItem('token', res.token);
        
        var role = this.userService.getRole();
        localStorage.setItem('role',role);

        if(role === 'Student'){
          this.profile$ = this.userService.getStudentProfileObservable();
          this.profile$.subscribe(x => {
            localStorage.setItem("id", String(x.id));
          });
          
          setTimeout(() => 
          {
              this.router.navigate(['/student']);
          },
          300);


        }
        else if (role == 'Teacher'){
          this.profile$ = this.userService.getTeacherProfileObservable();
          this.profile$.subscribe(x => {
            localStorage.setItem("id", String(x.id));
          });
          
          // this.router.navigateByUrl('/teacher');
          setTimeout(() => 
          {
              this.router.navigate(['/teacher']);
          },
          300);

        }
        
      },
      err => {
        console.log(err);
      }
    );
  }
}
