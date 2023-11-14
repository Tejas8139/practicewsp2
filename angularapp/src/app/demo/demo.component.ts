import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { FormGroup, FormControl,Validators } from '@angular/forms';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {

  constructor(private formbuilder:FormBuilder) { }
  empform=this.formbuilder.group({
    name:['',[Validators.required,Validators.maxLength(30)]],
    email:['',Validators.email],
    city:['',Validators.pattern("[a-zA-Z]")]

  })
save():void{
  console.log(this.empform.value)
}
  ngOnInit() {
  }

}
