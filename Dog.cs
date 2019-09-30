using System;

namespace excercises_classes
{
    //Övning 1 - del 2
    //Skapa en klass för ditt favoritdjur. 
    class Dog
    {
            //Gör om så att variablerna i din djur-klass är osynliga, private. 
            //De skall istället göras om till egenskaper (get & set). 
            //Använd egenskaperna i ett testobjekt. 
        private int age;
        public int Age 
        { 
            get 
            { 
                return age;
            }
            set 
            {
              age = value;  
            }
        }
        private string race; 
        public string Race
        { 
            get 
            { 
                return race;
            }
            set 
            {
              race = value;  
            }
        } 
        private string name;
        public string Name
        { 
            get 
            { 
                return name;
            }
            set 
            {
              name = value;  
            }
        }
        private void bark()
        {
            Console.WriteLine("Vov, vov!");
        }
        private void fetch()
        {
            Console.WriteLine("Go, go, go!");
        }
    }
}
