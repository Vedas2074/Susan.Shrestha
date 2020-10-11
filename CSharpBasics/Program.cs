 using System;
 using AccessModifierAndMethods;

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
            accessmodifier.CalculateAverage();
        }
    }
}
