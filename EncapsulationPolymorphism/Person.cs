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
    private int height;
    private int weight;

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
            if(value != null && value.Length >= 2 && value.Length <= 10) 
            {
                fName = value;
            }
            else
            {
                throw new ArgumentException($"Person error: Failed to set FName. Value {value} is invalid, FName cannot be null and must be between 2 and 10 characters long.");
            }
        } 
    }

    public string LName { 
        get { return lName; } 
        set 
        {
            if (value != null && value.Length >= 2 && value.Length <= 10)
            {
                lName = value;
            }
            else
            {
                throw new ArgumentException($"Person error: Failed to set LName. Value {value} is invalid, LName cannot be null and must be between 2 and 10 characters long.");
            }
        } 
    }

    public int Height { 
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

    public int Weight { 
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
