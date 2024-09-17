using EncapsulationPolymorphism;

namespace EncapsulationPolymorphismTests;

public class PersonTests
{
    [Fact]
    public void SetValidAge_CheckAge()
    {
        Person person = new Person();

        person.Age = 25;

        Assert.True(person.Age == 25);
    }

    [Fact]
    public void SetInvalidAge_RaiseException()
    {
        Person person = new Person();

        try
        {
            person.Age = 0;
        }
        catch(Exception _)
        {
            Assert.True(true);
            return;
        }

        Assert.Fail();
    }

    [Fact]
    public void SetValidFName_CheckFName()
    {
        Person person = new Person();

        person.FName = "Test";

        Assert.True(person.FName == "Test");
    }

    [Fact]
    public void SetInvalidFName_RaiseException()
    {
        Person person = new Person();

        try
        {
            person.FName = "";
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
        Person person = new Person();

        person.LName = "Test";

        Assert.True(person.LName == "Test");
    }

    [Fact]
    public void SetInvalidLName_RaiseException()
    {
        Person person = new Person();

        try
        {
            person.LName = "";
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
        Person person = new Person();

        person.Height = 180;

        Assert.True(person.Height == 180);
    }

    [Fact]
    public void SetInvalidHeight_RaiseException()
    {
        Person person = new Person();

        try
        {
            person.Height = 0;
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
        Person person = new Person();

        person.Weight = 80;

        Assert.True(person.Weight == 80);
    }

    [Fact]
    public void SetInvalidWeight_RaiseException()
    {
        Person person = new Person();

        try
        {
            person.Weight = 0;
        }
        catch (Exception _)
        {
            Assert.True(true);
            return;
        }

        Assert.Fail();
    }
}