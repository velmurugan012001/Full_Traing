import { Component } from '@angular/core';
import { InternModel } from 'src/models/internModel';
import { LoginedUserModel } from 'src/models/loginedUserModel';
import { RegisterService } from '../services/registration.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
intern:InternModel;
loggedInUser:LoginedUserModel;
constructor(private internRegisterService:RegisterService){
  this.intern = new InternModel();
  this.loggedInUser = new LoginedUserModel();
}
addGender(gender:any){
  this.intern.Gender = gender;
}
addIntern(){
  console.log(this.intern)
  this.internRegisterService.createIntern(this.intern).subscribe(data=>{
    this.loggedInUser = data as LoginedUserModel;
    localStorage.setItem("Token",this.loggedInUser.Token);
    console.log(this.loggedInUser);
  },
    (  err: any)=>{
    console.log(err)
  });
}
}
