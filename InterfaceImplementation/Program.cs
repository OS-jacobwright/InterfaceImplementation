using System;

namespace InterfaceImplementation
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            IESpace e = ESpace.Create<IESpace>();
            INeoApp neoApp = ESpace.Create<INeoApp>();
            INeoLibrary neoLibrary = ESpace.Create<INeoLibrary>();

            if (neoApp is INeoLibrary) {
                Console.WriteLine("We know this doesn't work.");
            }
            else {
                Console.WriteLine("This isn't supposed to work...");
            }

            if (neoLibrary is INeoApp) {
                Console.WriteLine("We know this doesn't work.");
            } 
            else {
                Console.WriteLine("This isn't supposed to work...");
            }

            if (neoApp.Is<INeoLibrary>()) {
                Console.WriteLine("Something still isn't right here!!!");
            }
            else {
                Console.WriteLine("Great Success :thumbsup:");
            }

            if (neoLibrary.Is<INeoApp>()) {
                Console.WriteLine("Something still isn't right here!!!");
            } 
            else {
                Console.WriteLine("Great Success :thumbsup:");
            }

            Console.WriteLine("Time to guess!");
            var guess = Mystery(1);
            if(guess.Is<INeoApp>()) {
                Console.WriteLine("We are an INeoApp!");
            }
            if (guess.Is<INeoLibrary>()) {
                Console.WriteLine("We are an INeoLibrary!");
            }

            Console.WriteLine("Our test is over.");
        }

        public static IOMLComponent Mystery(int var) {
            switch(var) {
                case 1: return ESpace.Create<INeoApp>();
                case 2: return ESpace.Create<IOMLComponent>();
                default: 
            return ESpace.Create<IESpace>();
            }
        }
    }
}