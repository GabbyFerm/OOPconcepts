//This is an example of polymorphism concept

namespace OOPconcepts
{   
    //This is the base class
   public class Vehicle
    {
        public virtual void MakeSound()
        {   
            //This is the metod for the base class
            Console.WriteLine("A vehicle makes some kind of sound.");
        }

    }

    //This is first subclass
    public class Car : Vehicle 
    {
        public override void MakeSound()
        {
            Console.WriteLine("A car makes the sound Wrooom");
        }
    }

    //This is second subclass
    public class Train : Vehicle 
    {
        public override void MakeSound()
        {
            Console.WriteLine("A train goes choo choo");
        }
    }
}
