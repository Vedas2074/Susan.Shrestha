using System;
using System.Linq;
class Methods
{
    void PrintInfo()
    {
        Console.WriteLine("Printing Something...");
    }
     void PrintingSomething(string message)
    {
        Console.WriteLine(message);
        Multiply(2.3f, 3.3f);
        Multiply(2.3f, 3.4f, 3.3f);
        Sum(2.3, 2.4, 2.3f, 3.4f, 3.3f, 2.3f, 3.4f, 3.3f);
        GetGreetings("Sushika", "Miss");
        GetGreetings("Susan");

        byte[] numbers = {56, 32, 255, 3, 67, 33, 36, 33, 234};
        (byte Max, byte Min) result = FindMinMax(numbers);
        //named arguments
        PrintCustomerDetails(age:21, name:"Susan", true, address:"Thankot"); 
    }

    float Multiply(float firstNum, float secondNum)
    {
        float product = firstNum * secondNum;
        return product;
    }

    float Multiply(float firstNum, float secondNum, float thirdNum)     //Function overloading -> same function name can be used if argument type or number of argument are differnet
    {
        float product = firstNum * secondNum * thirdNum;
        return product;
    }

    double Sum(params double[] numbers)  // Params can be used so that variable number of argument can be sent to any function
    {
        double sum = 0;
        foreach(double num in numbers)
        {
            sum = sum + num;
        }
        return sum;
    }

    //Optional argument
    string GetGreetings(string name, string prefix = "Mr") //string prifix is a optional argument, if no argument is sent then the default value is Mr
    {
        string fullName = $"{prefix}, {name}"; // string interpolation
        //string fullName = prefix + ", " + name; This can also be used for concadination
        return fullName;
    }

    //Returning multiple values
    (byte, byte) FindMinMax(byte[] numbers)
    {
        byte max = numbers.Max(); // number.Max() is possible since System.Ling is used above.
        byte min = numbers.Min();
        return(max, min);
    }

    void PrintCustomerDetails(string name, string address, byte age, bool isMale)
    {
        Console.WriteLine($"{name}, {age}, {address}");
    }

    float Subtract(float firstNum, float secondNum) => firstNum - secondNum; // Expresson bodied method syntax, if only one line code is there in a function then the function can be used in this way
}