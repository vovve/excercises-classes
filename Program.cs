using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1 - del 2
            //Skapa sedan ett testobjekt till klassen.
            Dog myDog = new Dog();
            myDog.Age = 13;
            myDog.Name = "Peps Persson";
            myDog.Race = "Griffon Belge"; 

            Console.WriteLine("Voff! Jag heter " + myDog.Name + " och är " + myDog.Age + " år gammal. Jag är en " + myDog.Race );
         
        }
    }
}
