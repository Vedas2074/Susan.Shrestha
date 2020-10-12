 using System;
 using AccessModifierAndMethods;
 //using P =  LearningClasses.Person; // Different ways of using namespace
using LearningClasses;

 namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter your name:");
            // string name = Console.ReadLine();
            // Console.WriteLine("Hi, I am " + name);

            //SelectionStatement selectionstatement = new SelectionStatement();
            //selectionstatement.LearnSwitchCases();

            Methods methods = new Methods();
            methods.PrintInfo();
            methods.PrintingSomething("Hi,");

            AccessModifier accessmodifier = new AccessModifier();
            accessmodifier.DoSomething();
           //accessmodifier.CalculateAverage(2, 3);

            Human human  = new Human(); //here person is the object from global class called person which is in properties.cs
            human.Name = "Susan";
            human.Age = 21; 
           string x = human.Address;

            //constructor
            //var p = new P(); // using the namespace called LearningClasses
            //First method to write code
            var person = new Person(); //Default constructor is called
            person.Name = "Susan";
            person.age = 21;
            person.Address = "Thankot";

            //Second method to write code
            var person2 = new Person("Sushika", "Teku", 21); // Parameterized constructor is called
            var person3 = new Person("Sanam", "Matatirtha", 21);
            var person4 = new Person();
            person4.Display();

        }
    }
}
