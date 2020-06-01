using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasicTest.BusinessObject
{
    public class Login
    {
        
        public string Name { get; set; }
        public string Password { get; set; }
        public string ProductName { get; set; }


        public Login(string Name, string Password)
        {
            this.Name = Name;
            this.Password = Password;            
        }
    }
}
