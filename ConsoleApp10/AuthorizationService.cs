using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class AuthorizationService
    {

        List<user> users = new List<user>()
        { 
            new  user { login="admin" , password="123"} , 
        };

        public bool IsAutChek(string login, string password)
        {

            if (string.IsNullOrEmpty(login) || string.IsNullOrWhiteSpace(login))
                return false;

            if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
                return false;

            if (users.Any(x => x.password == password && x.login ==login))
                return true;

            return false;
        }
    }
}

public class user
{
    public string login { get; set; }
    public string password { get; set; }
}