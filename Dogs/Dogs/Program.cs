using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog;
            myDog = new Dog("reksio");
            myDog.GetName();
            myDog.MakeNoise();

            // You need this so that the program doesn't close too soon.
            Console.ReadLine();
        }
    }

    class Dog
    {
        string Name;
        public string Gender;
        
        int index = 2;
        double mass = 5.1d;

        bool isMale = true; bool isPuppy = false;

        public Dog(string newName)
        {
            Name = newName;
        }

        public string GetName()
        {
            return Name;
        }

        public void MakeNoise()
        {
            Console.WriteLine("Hau hau - " + Name);
        }
    }
}
