import { Component, OnInit, Input } from '@angular/core';
import { TeacherService } from '../../teacher.service';
import { Observable } from 'rxjs';
import { StudentByTeacher } from './StudentByTeacher';

@Component({
  selector: 'app-student-node',
  templateUrl: './student-node.component.html',
  styleUrls: ['./student-node.component.css']
})
export class StudentNodeComponent implements OnInit {

   student:StudentByTeacher; 
   @Input() name:string;
   @Input() age:number;

  constructor(private teacherService: TeacherService) { }

  ngOnInit() {
  }

}
