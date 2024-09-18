namespace EncapsulationPolymorphism;

/// <summary>
/// Represents a person with age, name, weight and height.
/// </summary>
public class Person
{
    private int age;
    private string fName;
    private string lName;
    private double height;
    private double weight;

    /// <summary>
    /// Default constructor.
    /// </summary>
    public Person()
    {
        age = 0;
        fName = "";
        lName = "";
        height = 0;
        weight = 0;
    }

    /// <summary>
    /// Constructor with parameters.
    /// </summary>
    /// <param name="age"></param>
    /// <param name="fName"></param>
    /// <param name="lName"></param>
    /// <param name="height"></param>
    /// <param name="weight"></param>
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

    /// <summary>
    /// Age must be larger than 0.
    /// </summary>
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

    /// <summary>
    /// FName cannot be null and must be at least 2 characters long and at most 10 characters long.
    /// </summary>
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

    /// <summary>
    /// LName cannot be null and must be at least 2 characters long and at most 10 characters long.
    /// </summary>
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

    /// <summary>
    /// Height cannot be 0 or less.
    /// </summary>
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

    /// <summary>
    /// Weight cannot be 0 or less.
    /// </summary>
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
