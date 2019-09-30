using System;

namespace excercises_classes
{
    //Övning 1 - del 1
    //Skapa en klass för ditt favoritdjur. 
    class Dog
    {
            //Skapa klassmedlemmar (både variabler & metoder) som du tycker är lämpliga. 
            //T.ex. kan djuret innehålla de publika variablerna name, race och age 
            //samt de publika metoderna Bark() & Fetch(). 
        public int age;
        public string race;
        public string name;
        public void bark()
        {
            Console.WriteLine("Vov, vov!");
        }
        public void fetch()
        {
            Console.WriteLine("Go, go, go!");
        }
    }
}
