using System;

namespace Dog
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Lilly", "Paul", 3, Gender.Female);
            myDog.Bark(5);
            Console.WriteLine(myDog.GetTag());

            Dog puppy = new Dog("Rocco", "Jack", 1, Gender.Male);
            puppy.Bark(2);
            Console.WriteLine(puppy.GetTag());
        }
    }
}