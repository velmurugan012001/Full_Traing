export class LoginedUserModel{
    constructor(public userId:number=0,
        public Password:string="",
        public Token:string="",
        public Role:string="")
        {

}
}