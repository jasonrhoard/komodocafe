using KomodoCafe_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe_Console
{
    class ProgramUI
    {

        private MenuRepository _menuRepo = new MenuRepository();
        public void Run()
        {
            SeedMenuList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display options to use
                Console.WriteLine("Welcome to Komodo Cafe! Please select an option number:\n" +
                    "\n" +
                    "1. Create new menu items\n" +
                    "2. Update menu items\n" +
                    "3. Delete menu itmes\n" +
                    "4. List menu items\n" +
                    "5. Exit Komodo Cafe\n");
                //Get user's input

                string input = Console.ReadLine();

                //Evaluate the user's input and act accordingly
                switch (input)
                {

                    case "1":
                        CreateNewMenuItem();
                        break;

                    case "2":
                        UpdateMenuItem();
                        break;

                    case "3":
                        DeleteMenuItem();
                        break;

                    case "4":
                        ListMenuItems();
                        break;

                    case "5":
                        Console.WriteLine("Thank you for visiting Komodo Cafe!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter an option number 1, 2, 3, 4, or 5...");
                        break;


                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void CreateNewMenuItem()
        {
            Menu newItemNumber = new Menu();
            Console.WriteLine("Enter the new menu item number:");
            string numberAsString = Console.ReadLine();
            newItemNumber.MealNumber = int.Parse(numberAsString);

            Menu newItem = new Menu();
            Console.WriteLine("Enter the new menu item name:");
            newItem.MealName = Console.ReadLine();

            Menu newItemDescription = new Menu();
            Console.WriteLine("Enter the new menu item description:");
            newItemDescription.MealDescription = Console.ReadLine();

            Menu newItemIngredients = new Menu();
            Console.WriteLine("Enter the new menu item ingredients:");
            newItemIngredients.ListOfIngrediens = Console.ReadLine();

            Menu newItemPrice = new Menu();
            Console.WriteLine("Enter the new menu item price:");
            string priceAsString = Console.ReadLine();
            newItemPrice.Price = decimal.Parse(priceAsString);

            _menuRepo.AddItemsToMenux(newItem);

        }

        private void UpdateMenuItem()
        {
            Menu updateItemNumber = new Menu();
            Console.WriteLine("Please enter the menu item number you wish to update");
            string itemAsString = Console.ReadLine();
            updateItemNumber.MealNumber = int.Parse(itemAsString);

            //Menu updateItemNamer = new Menu();
            Console.WriteLine("Please enter the menu item name" );


        }
        private void DeleteMenuItem()
        {
            ListMenuItems();
            
            Console.WriteLine("Please enter the menu item name you wish to delete:");
            string deleteItemName = Console.ReadLine();


            bool wasDeleted = _menuRepo.DeleteMenuItems(deleteItemName);
            if (wasDeleted)
            {
                Console.WriteLine("The menu item was deleted.");
            }
            else
            {
                Console.WriteLine("Nothing to delete...");

            }

        }

        private void ListMenuItems()
        {
            List<Menu> menuList = _menuRepo.GetMenuItems();

            foreach(Menu item in menuList)
            {
                Console.WriteLine($"Number:{item.MealNumber}. " + $"Name:{item.MealName} " + $"Description:{item.MealDescription} " +$"Price: {item.Price}\n" );
            }


         
        }
        private void SeedMenuList()
        {
            Menu item1 = new Menu(1, "B and C", "Beans and Cornbread", "Beans, Cornbread", 5.00m);
            Menu item2 = new Menu(2, "F and C", "Fish and Chips", "Flour, Beer, Cod, Potatoes, Peanut Oil", 6.00m);
            Menu item3 = new Menu(3, "Rueben", "Rye, Corned Beef, Sauerkraut and Sauce", "Rye Bread, Corned Beef, Salt, Pepper, Sauerkruat, Thousand Island", 7.00m);
            Menu item4 = new Menu(4, "Taco Leaf", "A ground beef taco salad", "Romaine Lettuce, Ground Beef, Onion, Cumin", 8.00m);

            _menuRepo.AddItemsToMenux(item1);
            _menuRepo.AddItemsToMenux(item2);
            _menuRepo.AddItemsToMenux(item3);
            _menuRepo.AddItemsToMenux(item4);

        }
    }
}

