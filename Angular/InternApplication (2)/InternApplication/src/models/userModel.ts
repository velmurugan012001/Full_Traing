export  class UserModel{
    constructor(  public UserId :number=0,
                  public PasswordHash :string="",
                  public PasswordKey :string="",
                  public  Role :string="",
                  public  Status :string="",
                  public Password:string=""
       ){

    }
}