import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';


// import {MatNativeDateModule} from '@angular/material/core';
// import {platformBrowserDynamic} from '@angular/platform-browser-dynamic';
// import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
// import {DemoMaterialModule} from './app/material-module';
// import {MAT_FORM_FIELD_DEFAULT_OPTIONS} from '@angular/material/form-field';

import {Routes, RouterModule} from '@angular/router';


import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { TeacherComponent } from './teacher/teacher/teacher.component';
import { StudentsByTeacherComponent } from './teacher/students-by-teacher/students-by-teacher.component';
import { StudentNodeComponent} from './teacher/students-by-teacher/student-node/student-node.component';
import { TestsByTeacherComponent } from './teacher/tests-by-teacher/tests-by-teacher.component';
import { TestsByStudentNodeComponent} from './test/tests-node/tests-by-student-node.component';
import { StudentComponent} from './student/student/student.component';
import { TestComponent } from './test/test-for-student/test.component';
import { TestTeacherComponent } from './test/test-teacher/test-teacher.component';
import { RegistrationComponent} from './user/registration/registration.component';
import { NgForm} from '@angular/forms';
import { NewTestComponent} from './test/new-test/new-test.component';
import { LoginComponent } from './user/login/login.component';
import { AuthGuard } from './user/auth/auth.guard';
import { HomeComponent } from './home/home.component';
import { UserService } from './user/user.service';
import { AuthInterceptor } from './user/auth/auth.interceptor';
import { FordibbenComponent } from './user/fordibben/fordibben.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    TeacherComponent,
    StudentsByTeacherComponent,
    StudentNodeComponent,
    TestsByTeacherComponent,
    TestsByStudentNodeComponent,
    StudentComponent,
    LoginComponent,
    RegistrationComponent,
    TestComponent,
    NewTestComponent,
    TestTeacherComponent,
    HomeComponent,
    FordibbenComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
        { path: 'teacher', component: TeacherComponent, canActivate:[AuthGuard], data :{permittedRoles:['Teacher']} },
        { path: 'user/registration', component: RegistrationComponent},
        { path:'user/login', component: LoginComponent},
        { path: 'home', component: HomeComponent, canActivate:[AuthGuard]},
        { path: 'student', component: StudentComponent, canActivate:[AuthGuard], data :{permittedRoles:['Student']}},
        { path: 'fordibben', component: FordibbenComponent, canActivate:[AuthGuard]},
        { path: 'test/:id/student/:studentId', component: TestComponent},
        { path: 'test/:id/teacher/:teacherId/', component: TestTeacherComponent},
        { path: 'newtest/:teacherId', component: NewTestComponent}
    ])
  ],
  providers: [UserService, {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
