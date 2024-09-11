//This is an example of encapsulation concept

using System.Xml.Serialization;

namespace OOPconcepts
{
    //This is the main class
    public class Account {

        //Private attributes
        private string name;
        private string email;
        private string password;

        //Puplic constructor to initialise the attributes
        public Account(string name, string email, string password) 
        {
            Name = name;
            Email = email;
            Password = password;
        }

        //Public methods to get access to the private attributes
        public string Name 
        { 
            get { return name; }
            set { name = value; }
        
        }
        public string Email 
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        //Method to show the account information
        public void DisplayInfo() 
        {
            Console.WriteLine($"Name: {name}, Email: {email}, Password: {password}");
        }
    }
}
