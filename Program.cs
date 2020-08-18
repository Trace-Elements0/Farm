using System;
using ClassLibrary;


namespace Farm
{
    class Program
    {
         static void Main(string[] args)
         {
            //Create Farm instantiate new objects of each animal. And although the classes are located in a 
            //different project, by adding that project as a reference in this one and utilizing the appropriate
            //using statement those classes and all their functionality are visible

            //Using each classes default constructor(which was inherited from the base class"
            //to instantiate the objects and assign values to their properties
            Rabbit Buggs = new Rabbit(2, "Buggs", "Grey", Species.Leporidae);

                Horse SeaBiscuit = new Horse(8, "SeaBiscuit", "Brown", Species.Equine);

                Cow Bessy = new Cow(1, "Bessy", "Black", Species.Bovine);

                Pig BaConne = new Pig(7,"BaConne", "Pink", Species.Sus);

                Pig Babe = new Pig(5, "Babe", "Pink", Species.Sus);



            try
            {   //Intro
                Console.WriteLine("Welcome to the farm. We have a few animals. Would you like to meet the cows? (Type Yes or No.)\n");
                string response = Console.ReadLine();
                if (response == "Yes")
                {
                    Console.WriteLine("We have a cow. Named " + Bessy.Name);
                    Bessy.Moo();
                    Console.WriteLine(Bessy.ToString());
                    Console.WriteLine("This is our farm.\n");
                }
                else if (response == "No")
                {
                    Console.WriteLine("Thanks for stopping by!\n");
                }
                else
                {
                    Console.WriteLine("Please enter a valid response.\n");
                }

                Console.WriteLine("A horse.\n");
                SeaBiscuit.Neigh();

                Console.WriteLine("A couple pigs.\n");
                BaConne.Squeel();
                Babe.Munch();

                Console.WriteLine("Also, a rabbit.\n");
                Buggs.Hop();

            }
            catch (ResponseNotFoundException)
            {

            }
            finally
            {

            }
        }
    }
}
