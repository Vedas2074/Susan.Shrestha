using System;
using System.Linq;
using Persons;


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ - Language Integrated Query
            int[] numbers = {1, 3, 4, 5, 6, 13, 21};

            //Find all the elements from number which are less than 20 and greater than 1
            //Using method syntax - lambda expression
            var result = numbers.Where(x => x < 20 && x > 1);

            //Query syntax - Query expression
            var result2 = from x in numbers 
                            where x < 20 && x > 1
                            select x;
            string[] names = { "Susan", "Bijen", "Sanam", "Samip", "Biman"};

            //Find names that starts with letter 'S' and having length less than 6\
            var result3 = from name in names
                            where name.StartsWith("S") && name.Length < 6
                            select name;

            //Projections
            var result4 = from num in numbers
                            select num * num;

            //Ordering

            var result5 = from num in numbers       //Ascending
                            orderby num
                            select num;

            var result8 = from num in numbers       //Descending
                            orderby num descending
                            select num;

              //Partitioning
            var result6 = numbers.Take(5);
            var result7 = numbers.Skip(1).Take(5);

            //Quantifiers
            var isEvenThere = numbers.Any(num => num % 2 == 0);
            var areAllEven = numbers.All(num => num % 2 == 0);
            var is26there = numbers.Contains(5);

            var result9 = Enumerable.Range(1, 1000); //it gives collection of number from certain range
            var result10 = Enumerable.Repeat("Hello world", 10); //Repeat for certain number of times -- for this, it repeats for 10 times

            List<Person> people = new List<Person>()
            {
                new Person() {Id = 1, Firstname = "Susan", Lastname = "Shrestha", Address = "Ktm", Age = 21};
                new Person() {Id = 2, Firstname = "Sisan", Lastname = "Shrestha", Address = "Bkt", Age = 16};
                new Person() {Id = 3, Firstname = "Sosan", Lastname = "Shrestha", Address = "Pkh", Age = 20};
                new Person() {Id = 4, Firstname = "Sysan", Lastname = "Shrestha", Address = "Ktm", Age = 18};
                new Person() {Id = 5, Firstname = "Snsan", Lastname = "Shrestha", Address = "Bkt", Age = 3};
                new Person() {Id = 6, Firstname = "Shsan", Lastname = "Shrestha", Address = "Pkh", Age = 17};
                new Person() {Id = 7, Firstname = "Ssan", Lastname = "Shrestha", Address = "Kathmandu", Age = 18};
            };

            //Find all people who live in kathmandu
            var result11 = from person in people
                            where person.Address == "Kathmandu"
                            select person;

            //Find all people who are minors

        }
    }
}
