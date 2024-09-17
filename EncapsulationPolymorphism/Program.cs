using EncapsulationPolymorphism;
using EncapsulationPolymorphism.Errors;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //PersonTest();
        List<UserError> errors = [];
        for(int i = 0; i < 10; i++)
        {
            Random random = new();
            int index = random.Next(0, 5);
            switch (index)
            {
                case 0:
                    errors.Add(new DivideByZeroError());
                    break;
                case 1:
                    errors.Add(new InvalidIntegerError());
                    break;
                case 2:
                    errors.Add(new NumericInputError());
                    break;
                case 3:
                    errors.Add(new OutOfBoundsError());
                    break;
                case 4:
                    errors.Add(new TextInputError());
                    break;
            }
        }

        foreach(UserError error in errors)
        {
            Console.WriteLine(error.UEMessage());
        }
    }

    private static void PersonTest()
    {
        PersonHandler personHandler = new();

        Person person = new();

        for (int i = 0; i < 10; i++)
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