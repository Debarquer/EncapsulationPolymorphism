using EncapsulationPolymorphism;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        PersonHandler personHandler = new();

        Person person = new();

        for(int i = 0; i < 10; i++)
        {
            try
            {
                person = personHandler.CreateRandomPerson();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (person != null)
                    Console.WriteLine($"{person.FName} {person.LName} age: {person.Age}");
            }
        }
    }
}