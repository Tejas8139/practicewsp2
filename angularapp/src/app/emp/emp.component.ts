import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { FormGroup,FormControl,Validators } from '@angular/forms';
@Component({
  selector: 'app-emp',
  templateUrl: './emp.component.html',
  styleUrls: ['./emp.component.css']
})
export class EmpComponent implements OnInit {
  constructor(){}

//   constructor(private formbuilder:FormBuilder) { }
// empform=this.formbuilder.group({
//   name:['',[Validators.required,Validators.maxLength(40)]],
//   email:['',Validators.email],
//   city:['',Validators.pattern("[a-zA-Z]")]
// })
// save():void{
//   console.log(this.empform.value)
// }
  ngOnInit() {
  }

}
