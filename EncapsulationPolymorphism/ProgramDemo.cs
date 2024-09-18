using EncapsulationPolymorphism.Animals.Birds;
using EncapsulationPolymorphism.Animals;
using EncapsulationPolymorphism.Contracts;
using EncapsulationPolymorphism.Errors;

namespace EncapsulationPolymorphism
{
    internal class ProgramDemo
    {
        public static void AnimalsDemo()
        {
            List<Animal> animals = [];
            for (int i = 0; i < 20; i++)
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

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"The {animal.GetType()} says ");
                animal.DoSound();
                if (animal is IPerson person)
                {
                    Console.WriteLine($"The person says");
                    person.Talk();
                }
            }

            List<Dog> dogs = new List<Dog>();
            //dogs.Add(new Horse()); // F9 Conversion error, Horse does not derive from Dog
            // F10 The list needs to be of type Animal

            foreach (Animal animal in animals)
            {
                // The most specific version of the virtual function Stats is selected.
                // In other words, the Stats method that is implemented in the
                // child class at the bottom of the hierarchy.
                Console.WriteLine($"{animal.GetAnimalType()} stats: {animal.Stats()}");
            }

            Console.WriteLine("Now only the dogs:");
            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                    Console.WriteLine($"{animal.GetAnimalType()} stats: {animal.Stats()}");

                //animal.Fetch(); // Inaccessible, the Animals type does not know about the Fetch method.

                if (animal is Dog dog)
                {
                    dog.Fetch();
                }
            }
        }

        public static void ErrorsDemo()
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

        public static void PersonDemo()
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
}
