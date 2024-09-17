using EncapsulationPolymorphism;
using NuGet.Frameworks;

namespace EncapsulationPolymorphismTests;

public class PersonHandlerTests
{
    [Fact]
    public void SetValidAge_CheckAge()
    {
        PersonHandler personHandler = new();
        Person person = new();

        personHandler.SetAge(person, 25);

        Assert.True(person.Age == 25);
    }

    [Fact]
    public void SetInvalidAge_RaiseException()
    {
        PersonHandler personHandler = new();
        Person person = new();

        try
        {
            personHandler.SetAge(person, 0);
        }
        catch (Exception _)
        {
            Assert.True(true);
            return;
        }

        Assert.Fail();
    }

    [Fact]
    public void SetValidFName_CheckFName()
    {
        PersonHandler personHandler = new();
        Person person = new();

        personHandler.SetFName(person, "Test");

        Assert.True(person.FName == "Test");
    }

    [Fact]
    public void SetInvalidFName_RaiseException()
    {
        PersonHandler personHandler = new();
        Person person = new();

        try
        {
            personHandler.SetFName(person, "");
        }
        catch (Exception _)
        {
            Assert.True(true);
            return;
        }

        Assert.Fail();
    }

    [Fact]
    public void SetValidLName_CheckLName()
    {
        PersonHandler personHandler = new();
        Person person = new();

        personHandler.SetLName(person, "Test");

        Assert.True(person.LName == "Test");
    }

    [Fact]
    public void SetInvalidLName_RaiseException()
    {
        PersonHandler personHandler = new();
        Person person = new();

        try
        {
            personHandler.SetLName(person, "");
        }
        catch (Exception _)
        {
            Assert.True(true);
            return;
        }

        Assert.Fail();
    }

    [Fact]
    public void SetValidHeight_CheckHeight()
    {
        PersonHandler personHandler = new();
        Person person = new();

        personHandler.SetHeight(person, 180);

        Assert.True(person.Height == 180);
    }

    [Fact]
    public void SetInvalidHeight_RaiseException()
    {
        PersonHandler personHandler = new();
        Person person = new();

        try
        {
            personHandler.SetHeight(person, 0);
        }
        catch (Exception _)
        {
            Assert.True(true);
            return;
        }

        Assert.Fail();
    }

    [Fact]
    public void SetValidWeight_CheckWeight()
    {
        PersonHandler personHandler = new();
        Person person = new();

        personHandler.SetWeight(person, 80);

        Assert.True(person.Weight == 80);
    }

    [Fact]
    public void SetInvalidWeight_RaiseException()
    {
        PersonHandler personHandler = new();
        Person person = new();

        try
        {
            personHandler.SetWeight(person, 0);
        }
        catch (Exception _)
        {
            Assert.True(true);
            return;
        }

        Assert.Fail();
    }

    [Fact]
    public void CreatePerson_CheckForNull()
    {
        PersonHandler personHandler = new();

        Person person = personHandler.CreatePerson(25, "Test", "Test", 180, 80);

        Assert.False(person == null);
    }

    [Fact]
    public void CreateRandomPerson_CheckForNull()
    {
        PersonHandler personHandler = new();

        Person person = personHandler.CreateRandomPerson();

        Assert.False(person == null);
    }

    [Fact]
    public void GetCopy_CheckForNull()
    {
        PersonHandler personHandler = new();

        Person person = personHandler.CreatePerson(25, "Test", "Test", 180, 80);
        Person copy = personHandler.GetCopy(person);

        Assert.False(copy == null);
    }
}