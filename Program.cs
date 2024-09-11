using System.Security.Cryptography.X509Certificates;

namespace OOPconcepts
{
    //Here is our program class, our code runs here
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is the program for inheritence
            //Here is original class object
            Footballplayer player1 = new Footballplayer();

            player1.Running();

            //Here is subclass object
            Goalkeep player2 = new Goalkeep();

            player2.Catch();
            //Inheritence ends here


            //This is where polymorphism starts
            //This is the base vehicle
            Vehicle vehicle1 = new Vehicle();

            vehicle1.MakeSound();

            //This is the first vehicle
            Car vehicle2 = new Car();

            vehicle2.MakeSound();

            //This is the second vehicle
            Train vehicle3 = new Train();

            vehicle3.MakeSound();
            //This is where polymorphism ends

            //This is where encapsulation starts
            Account myAccount = new Account("Gabby", "emailadress.com", "xxxxxxxxxx");

            myAccount.DisplayInfo();
            //This is where encapsulation ends

            //This is where abstraction starts
            Male myMale = new Male();
            myMale.StartDance();

            Femail myFemail = new Femail();
            myFemail.StartDance();

            myMale.StopDance();
            myFemail.StopDance();
            //This is where abstraction ends
        }
    }
}
