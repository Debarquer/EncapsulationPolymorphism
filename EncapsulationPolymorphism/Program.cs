using EncapsulationPolymorphism;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Person person = new();

        try
        {
            //person.Age = new Random().Next(200) - 100;
            person.Age = 0;
            person.FName = "Per";
            person.LName = "Lund";
            person.Height = 180;
            person.Weight = 80;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        // Public properties are directly accessible, but not private members.
        Console.WriteLine($"{person.FName} {person.LName} age: {person.Age}");
    }
}