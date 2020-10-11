class Person
{
    // string name;
    int age = 23;

    public int Age
    {
        get 
        {
            return age;
        }
        set
        {
            if(value > 20 && value < 30)
            age = value;
        }
    }

    //Autoimplemented property
    public string Name { get; set; }
    public string Address { get; } //Readonly Property


}