
using System.Net;
using System.Net.Security;

namespace RestaurantMenu;

public class MenuItem
{
 public string Name {get; set; }
 public double Price { get; set; }
 public string Description { get; set; }
 public string Category { get; set; }

 public bool IsNew { get; set; }

//  public bool isNew {}
public DateTime DateAdded { get; set; }

public MenuItem(string name, double price, string description, string category)
 {
    Name = name;
    Price = price;
    Description = description;
    Category = category;
 }
public bool IsNewMenuItem() 
 {
    TimeSpan age = DateTime.Now.Subtract(DateAdded);
    int howOld = age.Days;
    return howOld < 90;
 }


// override ToString()
public override string ToString()
    {
        string newText = IsNewMenuItem() ? " New Item!" : "";
        string nl = Environment.NewLine;
        return Name + newText + nl + Description + nl + "$" + Price;
    }



    // override Equals() and GetHashCode()
    public override bool Equals(object? toBeCompared)
    {
        if (this == toBeCompared)
        {
            return true;
        }
        if (toBeCompared == null)
        {
            return false;
        }
        if (GetType() != toBeCompared.GetType())
        {
            return false;
        }
        MenuItem otherItem = (MenuItem)toBeCompared;
        return Name == otherItem.Name;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Name);
    }


    //INSTANCE METHODS 

    // Define IsNew
}