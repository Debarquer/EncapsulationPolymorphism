using EncapsulationPolymorphism;
using EncapsulationPolymorphism.Animals;
using EncapsulationPolymorphism.Animals.Birds;
using EncapsulationPolymorphism.Errors;
using System.Xml.Linq;

/// Questions
/// 13. New bird features should be added to the bird class.
/// 14. New animal features should be added to the animal class.



/// <summary>
/// 
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //PersonTest();
        //ErrorsTest();

        List<Animal> animals = [];
        for (int i = 0; i < 10; i++)
        {
            Random random = new();
            int index = random.Next(0, 9);
            switch (index)
            {
                case 0:
                    animals.Add(new Dog());
                    break;
                case 1:
                    animals.Add(new Hedgehog());
                    break;
                case 2:
                    animals.Add(new Horse());
                    break;
                case 3:
                    animals.Add(new Wolf());
                    break;
                case 4:
                    animals.Add(new WolfMan());
                    break;
                case 5:
                    animals.Add(new Worm());
                    break;
                case 6:
                    animals.Add(new Flamingo());
                    break;
                case 7:
                    animals.Add(new Pelican());
                    break;
                case 8:
                    animals.Add(new Swan());
                    break;
            }
        }

        foreach(Animal animal in animals)
        {
            Console.WriteLine($"The {animal.GetType()} says ");
            animal.DoSound();
        }
    }

    private static void ErrorsTest()
    {
        List<UserError> errors = [];
        for (int i = 0; i < 10; i++)
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

        foreach (UserError error in errors)
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