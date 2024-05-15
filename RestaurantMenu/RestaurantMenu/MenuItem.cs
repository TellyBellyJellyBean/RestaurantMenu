namespace RestaurantMenu;

public class MenuItem
{
 private double Price { get; set; }
 private string Description { get; set; }
 private string Category { get; set; } // do validation for setter: APP, MAIN COURSE, DESSERT
 private bool IsNew { get; set; }

 public MenuItem(double price, string description, string category, bool isNew)
 {
    Price = price;
    Description = description;
    Category = category;
    IsNew = isNew;
 }
}
