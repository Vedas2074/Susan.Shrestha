using System.Collections.Generic;

public class Collections
{
    public void LearnAboutList()
    {
        List<string> names = new List<string>() // List is buildin generic class
        {
           "Ram", // initiallizing at first
           "Shyam" 
        };
        names.Add("Susan"); //Adding in list
        names.Add("aSusan");
        names.Add("bSusan");
        names.Add("cSusan");
        names.Add("dSusan");

        names.Sort();
    }

    public void LearnAboutDictionary() //Holds key-value pairs
    {
        Dictionary<string, string> countryCapital = new Dictionary<string, string>()
        {
            ["Bhutan"] = "Thimpu", // initiallizing at first
            ["Japan"] = "Tokyo"
        };
        countryCapital.Add("Nepal", "Kathmandu"); // Here Nepal is key and Kathmandu is value. For each addition key must be unique else error occurs.
        countryCapital.Add("India", "Delhi");
        countryCapital.Add("USA", "WDC");
        countryCapital.Add("Canada", "Kathmandu");
        countryCapital.Add("China", "Beijing");
    }
}