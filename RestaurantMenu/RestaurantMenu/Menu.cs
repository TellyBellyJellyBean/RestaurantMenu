using System.Runtime.CompilerServices;
using System.Text;

namespace RestaurantMenu;

public class Menu
{
    public List<MenuItem> MenuItems { get; set; } = [];

    public DateTime LastUpdated { get; set; } = DateTime.Now;
    
    public void AddMenuItem(MenuItem newMenuItem)
    {
        if (MenuItems.Contains(newMenuItem))
        {
            Console.WriteLine("Already on the menu!");
        }
        else 
        {
        MenuItems.Add(newMenuItem);
        LastUpdated = DateTime.Now;
        newMenuItem.DateAdded = DateTime.Now;
        }
    }
    public void RemoveMenuItem(MenuItem currentMenuItem)
    {
        MenuItems.Remove(currentMenuItem);
        Console.WriteLine("Menu item removed.");
        LastUpdated = DateTime.Now;
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        StringBuilder appetizer = new();
        StringBuilder mainCourse = new();
        StringBuilder dessert = new();
        foreach (MenuItem menuItem in MenuItems)
        {
            if (Equals(menuItem.Category, "Appetizer"))
            {
                appetizer.Append(nl).Append(menuItem);
            }
            else if (Equals(menuItem.Category, "Main Course"))
            {
                mainCourse.Append(nl).Append(menuItem);
            }
            else if (Equals(menuItem.Category, "Dessert"))
            {
                dessert.Append(nl).Append(menuItem);
            }
        }
        return nl + "KT's MENU:" 
        + nl
        + "APPETIZERS" + appetizer
        + nl
        + "MAIN COURSES" + mainCourse
        + nl
        + "DESSERTS" + dessert
        + nl 
        + "Updated: " + LastUpdated.ToString("f");
    }
}
