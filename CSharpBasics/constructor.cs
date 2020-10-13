using System;
namespace LearningClasses
{
    public class Person
    {
        int x;
        public string Name { get; set; }
        public string Address { get; set; }
        public byte Age { get; set; }
        public static string ScientificName = "Homo-Sapiens";
        public Person() //Default parameterless constructor
        {
            x = 10;
        }

        //parametarized constructor
        public Person(string n, string add, byte age)
        {
            this.Name = n; //Represents current object of class
            this.Address = add;
            this.Age = age;
        }
        public void Display()
        {
            Console.WriteLine($"The value of x is {x}");
        }

        public static void Do()
        {
            
        }
    }

}
