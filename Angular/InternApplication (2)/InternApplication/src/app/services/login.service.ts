import { Injectable } from '@angular/core';
import {HttpClient}from '@angular/common/http';
import { Observable } from 'rxjs';
import { UserDTOModel } from 'src/models/userDTOModel';





@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private httpClient:HttpClient) {

   }
   createUser(User:UserDTOModel):Observable<any>{
    return this.httpClient.post("http://localhost:5156/api/User/Login",User);
   }
}
