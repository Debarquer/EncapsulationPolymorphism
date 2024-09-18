using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism;

public class Person
{
    private int age;
    private string fName;
    private string lName;
    private double height;
    private double weight;

    public Person()
    {
        age = 0;
        fName = "";
        lName = "";
        height = 0;
        weight = 0;
    }

    public Person(int age, string fName, string lName, double height, double weight)
    {
        Age = age;
        FName = fName;
        LName = lName;
        Height = height;
        Weight = weight;
        Age = age;
        FName = fName;
        LName = lName;
        Height = height;
        Weight = weight;
    }

    public int Age { 
        get { return age; } 
        set 
        {  
            if(value > 0)
            {
                age = value;
            }
            else
            {
                throw new ArgumentException($"Person error: Failed to set Age. Value {value} is invalid, Age must larger than 0");
            }
        } 
    }

    public string FName { 
        get {  return fName; } 
        set 
        {  
            if(value == null)
            {
                throw new ArgumentNullException("FName");
            }
            else if (value.Length < 2)
            {
                throw new ArgumentException($"Person error: FName cannot less than 2 characters long.");
            }
            else if (value.Length > 10)
            {
                throw new ArgumentException($"Person error: FName cannot more than 10 characters long.");
            }

            fName = value;
        }
    }

    public string LName { 
        get { return lName; } 
        set 
        {
            if (value == null)
            {
                throw new ArgumentNullException("lName");
            }
            else if (value.Length < 2)
            {
                throw new ArgumentException($"Person error: lName cannot less than 2 characters long.");
            }
            else if (value.Length > 10)
            {
                throw new ArgumentException($"Person error: lName cannot more than 10 characters long.");
            }

            lName = value;
        }
    }

    public double Height { 
        get { return height; } 
        set 
        {
            if (value > 0)
            {
                height = value;
            }
            else
            {
                throw new ArgumentException($"Person error: Failed to set Height. Value {value} is invalid, Height must larger than 0");
            }
        } 
    }

    public double Weight { 
        get { return weight; } 
        set 
        {
            if (value > 0)
            {
                weight = value;
            }
            else
            {
                throw new ArgumentException($"Person error: Failed to set Weight. Value {value} is invalid, Weight must larger than 0");
            }
        } 
    }
}
