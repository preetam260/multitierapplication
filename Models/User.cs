using System;


public class User
{
    //encapsulation
    public string Name {get; set;}
    public string Email {get; set;}
    public string PhoneNo {get; set;}

    public User(string name, string email, string phoneno)
    {
        this.Name = name;
        this.Email = email;
        this.PhoneNo = phoneno;
    }
}