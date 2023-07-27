import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { InternModel } from "src/models/internModel";

@Injectable()
export class RegisterService{
    constructor(private httpClient:HttpClient){

    }
    createIntern(intern:InternModel):Observable<any>{
        return this.httpClient.post("http://localhost:5156/api/User/Register",intern);
    }
}