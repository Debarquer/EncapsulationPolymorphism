using EncapsulationPolymorphism;

/// Questions
/// 3.3.13. New bird features should be added to the bird class.
/// 3.3.14. New animal features should be added to the animal class.
/// 3.4.9. Conversion error, Horse does not derive from Dog
/// 3.4.10. The list needs to be of type Animal
/// 3.4.13
/// The most specific version of the virtual function Stats is selected.
/// In other words, the Stats method that is implemented in the
/// child class at the bottom of the hierarchy.
/// 3.4.17
/// Because the Animals type does not know about the Fetch method. Inheritance is only one-way.



internal class Program
{
    private static void Main(string[] args)
    {
        ProgramDemo.AnimalsDemo();
        //ProgramDemo.PersonDemo();
        //ProgramDemo.ErrorsDemo();
    }
}