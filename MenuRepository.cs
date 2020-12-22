using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe_Repository
{
    
        public class MenuRepository
        {
            private List<Menu> _menuContent = new List<Menu>();

            public void AddItemsToMenux(Menu items)
            {
                _menuContent.Add(items);
            }

            public List<Menu> GetMenuItems()
            {
                return _menuContent;
            }

            public void UpdateMenuItems(string currentItem, Menu newMenuItem)
            {
                Menu oldItem = GetMenuItems(currentItem);
                if (oldItem != null)
                {
                    oldItem.MealName = newMenuItem.MealName;
                    oldItem.MealNumber = newMenuItem.MealNumber;
                    oldItem.MealDescription = newMenuItem.MealDescription;
                    oldItem.ListOfIngrediens = newMenuItem.ListOfIngrediens;
                    oldItem.Price = newMenuItem.Price;

                }
            }

            public bool DeleteMenuItems(string menuItem)
            {
                Menu item = GetMenuItems(menuItem);

                if (item == null)
                {
                    return false;
                }

                int menuItemCount = _menuContent.Count;
                _menuContent.Remove(item);

                if (menuItemCount > _menuContent.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            private Menu GetMenuItems(string menuItem)
            {


                foreach (Menu item in _menuContent)
                {
                    if (item.MealName == menuItem)
                    {
                        return item;
                    }
                }
                return null;
            }
        }
}
