namespace LearningClasses
{
    internal class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public byte age { get; set; }
        public Person() //Default parameterless constructor
        {

        }

        //parametarized constructor
        public Person(string n, string add, byte age)
        {
            this.Name = n; //Represents current object of class
            this.Address = add;
            this.age = age;
        }
        


    }

}
