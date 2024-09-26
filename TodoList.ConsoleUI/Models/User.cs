using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.ConsoleUI.Models;

public sealed class User : Entity<int>
{
    public User()
    {

    }

    public User(int id ,string name , string surname, int age , string email , string password)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Age = age;
        Email = email;
        Password = password;
    }
    
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public override string ToString()
    {
        return $"Name : {Name} Surname : {Surname} Age : {Age} Email : {Email} Password : {Password}";
    }

}
