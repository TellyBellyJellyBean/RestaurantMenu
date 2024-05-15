namespace RestaurantMenu;

public class Menu
{
 private List<MenuItem> MenuItems { get; set; } = [];

 private DateTime LastUpdated { get; }

 public Menu(List<MenuItem> menuItems, DateTime lastUpdated)
 {
    MenuItems = menuItems;
    LastUpdated = lastUpdated;
 }
}
