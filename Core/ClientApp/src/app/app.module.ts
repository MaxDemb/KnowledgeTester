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
import { NavMenuComponent } from './nav-menu/nav-menu/nav-menu.component';
import { TeacherComponent } from './teacher/teacher/teacher.component';
import { TestsByTeacherComponent } from './teacher/tests-by-teacher/tests-by-teacher.component';
import { StudentComponent} from './student/student/student.component';
import { RegistrationComponent} from './user/registration/registration.component';
import { NgForm} from '@angular/forms';
import { NewTestComponent} from './test/new-test/new-test.component';
import { LoginComponent } from './user/login/login.component';
import { AuthGuard } from './user/auth/auth.guard';
import { UserService } from './user/user.service';
import { AuthInterceptor } from './user/auth/auth.interceptor';
import { FordibbenComponent } from './user/fordibben/fordibben.component';
import { CreateQuestionComponent} from './question/create-question/create-question.component';
import {TestStudentComponent } from './student/test-student/test-student.component';
import {PassQuestionComponent} from './question/pass-question/pass-question.component';
import {FooterComponent} from './nav-menu/footer/footer.component';
import {PassTestComponent} from './test/pass-test/pass-test.component';
import { ResultComponent} from './results/result/result.component';
import {StudentByResultComponent} from './results/student-by-result/student-by-result.component';

@NgModule({
  declarations: [
    FooterComponent,
    AppComponent,
    NavMenuComponent,
    TeacherComponent,
    TestsByTeacherComponent,
    StudentComponent,
    LoginComponent,
    RegistrationComponent,
    NewTestComponent,
    FordibbenComponent,
    CreateQuestionComponent,
    TestStudentComponent,
    PassTestComponent,
    PassQuestionComponent,
    ResultComponent,
    StudentByResultComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'registration', component: RegistrationComponent},
      { path: 'login', component: LoginComponent},
      { path: 'teacher', component: TeacherComponent, canActivate:[AuthGuard], data :{permittedRoles:['Teacher']} },
      { path: 'newtest', component: NewTestComponent , canActivate:[AuthGuard], data :{permittedRoles:['Teacher']} },
      { path: 'create-question', component: CreateQuestionComponent, canActivate:[AuthGuard], data :{permittedRoles:['Teacher']} },
      { path: 'results', component: ResultComponent, canActivate:[AuthGuard], data :{permittedRoles:['Teacher']} },
      { path: 'student', component: StudentComponent, canActivate:[AuthGuard], data :{permittedRoles:['Student']}},
      { path: 'pass-test', component: PassTestComponent,  canActivate:[AuthGuard], data :{permittedRoles:['Student']}}
      // { path: 'fordibben', component: FordibbenComponent, canActivate:[AuthGuard]},
      // { path: 'test/:id/student/:studentId', component: TestComponent},
      // { path: 'test/:id/teacher/:teacherId/', component: TestTeacherComponent},
      // { path: 'newtest', component: NewTestComponent , canActivate:[AuthGuard], data :{permittedRoles:['Teacher']} },
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
