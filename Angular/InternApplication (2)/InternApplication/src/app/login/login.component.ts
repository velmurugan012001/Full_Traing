import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginedUserModel } from 'src/models/loginedUserModel';
import { LoginService } from '../services/login.service';
import { UserDTOModel } from 'src/models/userDTOModel';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  User: UserDTOModel;
  loginedUser: LoginedUserModel;

  constructor(
    private loginService: LoginService,
    private router: Router,
   
  ) {
    this.User = new UserDTOModel();
    this.loginedUser = new LoginedUserModel();
  }

  addUser() {
    this.loginService.createUser(this.User).subscribe(
       data => {
        this.loginedUser = data as LoginedUserModel;
        localStorage.setItem('Token', this.loginedUser.Token);
    
        
        
      },
      (err) => {
        console.log(err);
      }
    );
  }
}

