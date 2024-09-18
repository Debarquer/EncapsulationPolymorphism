namespace EncapsulationPolymorphism;

/// <summary>
/// Handles creating and modifying objects of the Person class.
/// </summary>
public class PersonHandler
{
    /// <summary>
    /// Updates the Age property of person.
    /// </summary>
    /// <param name="person"></param>
    /// <param name="age"></param>
    public void SetAge(Person person, int age)
    {
        person.Age = age;
    }

    /// <summary>
    /// Returns the Age property of person.
    /// </summary>
    /// <param name="person"></param>
    /// <returns>The age property of person.</returns>
    public int GetAge(Person person) => person.Age;

    /// <summary>
    /// Updates the FName property of person.
    /// </summary>
    /// <param name="person"></param>
    /// <param name="fName"></param>
    public void SetFName(Person person, string fName)
    {
        person.FName = fName;
    }

    /// <summary>
    /// Returns the FName property of person.
    /// </summary>
    /// <param name="person"></param>
    /// <returns>The FName property of person.</returns>
    public string GetFName(Person person) => person.FName;

    /// <summary>
    /// Updates the LName property of person.
    /// </summary>
    /// <param name="person"></param>
    /// <param name="lName"></param>
    public void SetLName(Person person, string lName)
    {
        person.LName = lName;
    }

    /// <summary>
    /// Returns the LName property of person.
    /// </summary>
    /// <param name="person"></param>
    /// <returns>The LName property of person.</returns>
    public string GetLName(Person person) => person.LName;

    /// <summary>
    /// Updates the Height property of person.
    /// </summary>
    /// <param name="person"></param>
    /// <param name="height"></param>
    public void SetHeight(Person person, double height)
    {
        person.Height = height;
    }

    /// <summary>
    /// Returns the Height property of person.
    /// </summary>
    /// <param name="person"></param>
    /// <returns>The Height property of person.</returns>
    public double GetHeight(Person person) => person.Height;

    /// <summary>
    /// Updates the Weight property of person.
    /// </summary>
    /// <param name="person"></param>
    /// <param name="weight"></param>
    public void SetWeight(Person person, double weight)
    {
        person.Weight = weight;
    }

    /// <summary>
    /// Returns the Weight property of person.
    /// </summary>
    /// <param name="person"></param>
    /// <returns>The Weight property of person.</returns>
    public double GetWeight(Person person) => person.Weight;

    /// <summary>
    /// Creates a person with random properties.
    /// </summary>
    /// <returns>The newly created person.</returns>
    public Person CreateRandomPerson()
    {
        Random random = new();

        int age = random.Next(100);
        string fName = "Test" + random.Next(1000);
        string lName = "Test" + random.Next(1000);
        int height = random.Next(100);
        int weight = random.Next(100);

        return CreatePerson(age, fName, lName, height, weight);
    }

    /// <summary>
    /// Returns a copy of person.
    /// </summary>
    /// <param name="person">The original person that will be copied.</param>
    /// <returns>The created copy of person.</returns>
    public Person GetCopy(Person person)
    {
        return CreatePerson(person.Age, person.FName, person.LName, person.Height, person.Weight);
    }

    /// <summary>
    /// Creates and returns a new person.
    /// </summary>
    /// <param name="age"></param>
    /// <param name="fname"></param>
    /// <param name="lname"></param>
    /// <param name="height"></param>
    /// <param name="weight"></param>
    /// <returns>The newly created person.</returns>
    public Person CreatePerson(int age, string fname, string lname, double height, double weight)
    {
        return new Person(age, fname, lname, height, weight);
    }
}
