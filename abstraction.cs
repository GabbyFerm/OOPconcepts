//This is an example of the abstraction concept

using System.Xml.Serialization;

namespace OOPconcepts
{
    //This is an abstract main class
    public abstract class Dancer 
    {
        //This is the methods for the main class
        public abstract void StartDance();
        public abstract void StopDance();

    }

    //This is a concrete class Male
    public class Male : Dancer 
    {
        public override void StartDance()

        {
            Console.WriteLine("A male dancer starts dancing.");
        }

        public override void StopDance()

        {
            Console.WriteLine("A male dancer stops dancing.");
        }
    }

    //This is a concrete class Male
    public class Femail : Dancer
    {
        public override void StartDance()
        {
            Console.WriteLine("A female dancer starts dancing.");
        }

        public override void StopDance()
        {
            Console.WriteLine("A female dancer stops dancing.");
        }
    }
}
