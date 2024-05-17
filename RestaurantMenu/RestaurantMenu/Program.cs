// See https://aka.ms/new-console-template for more information
using RestaurantMenu;

Console.WriteLine("Welcome!");

// Menu items
MenuItem menuItem1 = new 
    (
        "Gooey Butter Cake",
        8,
        "Gooey, Butter, and Cake",
        "Dessert"
        
    );
MenuItem menuItem2 = new 
    (
        "Pizza Slice",
        2.00,
        "Dough, tomatoes, cheese, and whatever ya want.",
        "Main Course"
        
    );
MenuItem menuItem3 = new 
    (
        "Toasted Ravioli",
        6.00,
        "Stuffed with beef and cheese. A true St. Louis hallmark.",
        "Appetizer"
        
    );
MenuItem menuItem4 = new 
    (
        "Steak and Eggs",
        49.99,
        "Steak, Eggs, and your choice of seafood as a side.",
        "Main Course"
        
    );
// New Menu class
Menu menu = new();

//AddMenuItems
menu.AddMenuItem(menuItem1);
menu.AddMenuItem(menuItem2);
menu.AddMenuItem(menuItem3);
menu.AddMenuItem(menuItem2);
menu.AddMenuItem(menuItem4);

menu.RemoveMenuItem(menuItem2);

menu.AddMenuItem(menuItem2);


Console.WriteLine(menu.MenuItems.Count);

Console.WriteLine(menu);