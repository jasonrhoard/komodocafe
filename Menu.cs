using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe_Repository
{
    public class Menu
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string ListOfIngrediens { get; set; }
        public decimal Price { get; set; }

        public Menu() { }

        public Menu(int mealNumber, string mealName, string mealDescription, string listOfIngredients, decimal price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            ListOfIngrediens = listOfIngredients;
            Price = price;
        }
    }
}
