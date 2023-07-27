import { UserModel } from "./userModel";
export class InternModel{
    constructor(  public Id:number =0,
        public  User:UserModel=new UserModel(),
        public  Name:string="",
        public dateOfBirth:Date=new Date(), 
        public  Age:number=0, 
        public  Gender:string="",
        public  Phone:string="",
        public  Email:string="")
        {

        }
}