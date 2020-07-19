import { Component, OnInit } from '@angular/core';
import { UserModel } from '../User';
import { UserService } from '../user.service';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { ProfileFromBack } from '../ProfileFromBack';

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
  profile$ :Observable<ProfileFromBack>;

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
        
        var role = this.userService.getRole();
        localStorage.setItem('role',role);

        if(role === 'Student'){
          this.profile$ = this.userService.getStudentProfileObservable();
          this.profile$.subscribe(x => {
            localStorage.setItem("id", String(x.id));
          });
          
          this.router.navigateByUrl('/student');


        }
        else if (role == 'Teacher'){
          this.profile$ = this.userService.getTeacherProfileObservable();
          this.profile$.subscribe(x => {
            localStorage.setItem("id", String(x.id));
          });
          
          this.router.navigateByUrl('/teacher');


        }
        
      },
      err => {
        console.log(err);
      }
    );
    
    
  
  }
}
