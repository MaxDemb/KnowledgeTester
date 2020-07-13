import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';


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
import { UserComponent} from './user/user.component';
import { NgForm} from '@angular/forms';
import { NewTestComponent} from './test/new-test/new-test.component';

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
    UserComponent,
    RegistrationComponent,
    TestComponent,
    NewTestComponent,
    TestTeacherComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
        { path: 'teacher', component: TeacherComponent },
        { path: 'user/registration', component: RegistrationComponent},
        { path: 'user',  component: UserComponent} ,
       // { path: 'students-by-teacher', component: StudentsByTeacherComponent},
       // { path: 'student-node', component: StudentNodeComponent},
        //{ path: 'tests-by-teacher', component: TestsByTeacherComponent},
        //{ path: 'tests-by-teacher-node', component: TestsByTeacherNodeComponent},
        { path: 'student', component: StudentComponent},
        { path: 'test/:id/student/:studentId', component: TestComponent},
        { path: 'test/:id/teacher/:teacherId/', component: TestTeacherComponent},
        { path: 'newtest/:teacherId', component: NewTestComponent}
    ])
  ],
  providers: [
    
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
