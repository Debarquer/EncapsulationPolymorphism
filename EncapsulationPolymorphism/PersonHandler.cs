using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace EncapsulationPolymorphism;

public class PersonHandler
{
    public void SetAge(Person person, int age)
    {
        person.Age = age;
    }

    public int GetAge(Person person) => person.Age;

    public void SetFName(Person person, string fName)
    {
        person.FName = fName;
    }

    public string GetFName(Person person) => person.FName;

    public void SetLName(Person person, string lName)
    {
        person.LName = lName;
    }

    public string GetLName(Person person) => person.LName;

    public void SetHeight(Person person, double height)
    {
        person.Height = height;
    }

    public double GetHeight(Person person) => person.Height;

    public void SetWeight(Person person, double weight)
    {
        person.Weight = weight;
    }

    public double GetWeight(Person person) => person.Weight;

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

    public Person GetCopy(Person person)
    {
        return CreatePerson(person.Age, person.FName, person.LName, person.Height, person.Weight);
    }

    public Person CreatePerson(int age, string fname, string lname, double height, double weight)
    {
        return new Person(age, fname, lname, height, weight);
    }
}
