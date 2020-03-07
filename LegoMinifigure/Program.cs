using System;


namespace LegoMinifigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var astronaut = new Astronaut("Major Tom", "Janitor");
            astronaut.Promote();
            astronaut.DoYourJob();

            var casper = new Ghost("Casper", DateTime.Today)
            {
                IsFriendly = true,
                IsVisible = true,
            };
            var stretch = new Ghost("Stretch", new DateTime(1895, 12, 1))
            {
                IsFriendly = false
            };
            casper.Spook();
            casper.Haunt("Whipstaff Manor");
            casper.Spook();


            Console.ReadKey();
        }
    }
}
