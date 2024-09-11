//This is an example of inhetritence concept

namespace OOPconcepts
{
    //This is the main class, our subclass also inherits all the attributes from here.
    public class Footballplayer
    {   //These are the attributes for our main class
        public string Shoes;
        public string Socks;
        public string Shorts;

        public void Running()
        {   //This is a metod of main class
            Console.WriteLine("Every player runs around the field.");
        }
    }
    //This is the sub class with its specific attributes that the main class dont have.
    public class Goalkeep : Footballplayer
    {   //These are the specific attributes for our sub class
        public string Gloves;
        public string Position;

        public void Catch()
        {   //This is a metod for our sub class
            Console.WriteLine("Goalkeeper stands in the goal and hopefully catches all the balls!");
        }
    }
}
