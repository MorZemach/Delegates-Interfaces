namespace Ex04.Menus.Delegates
{
    using System;

    public class MainMenu
    {
        private const byte k_MinMenuValue = 0;
        private readonly SubMenuItem r_Menu;

        public MainMenu(string i_MenuName)
        {
            r_Menu = new SubMenuItem(i_MenuName);
        }

        public SubMenuItem Menu
        { 
            get { return r_Menu; } 
        }

        public void Show()
        {
            MenuItem currentMenuItem = r_Menu;

            while (currentMenuItem.MenuItemName != "Exit")
            {
                try
                {
                    menuItemSelection(ref currentMenuItem);
                }
                catch (FormatException i_FormatException)
                {
                    Console.WriteLine(string.Format("{0}{1}", i_FormatException.Message, Environment.NewLine));
                }
                catch (Exception i_Exception)
                {
                    Console.WriteLine(string.Format("{0}{1}", i_Exception.Message, Environment.NewLine));
                }
            }
        }

        private void menuItemSelection(ref MenuItem io_CurrentMenuItem)
        {
            if (io_CurrentMenuItem is SubMenuItem)
            {
                io_CurrentMenuItem = getUserSelectedMenuItem(io_CurrentMenuItem as SubMenuItem);
                Console.Clear();
            }
            else
            {
                if (io_CurrentMenuItem.MenuItemName != "Back")
                {
                    Console.Clear();
                    io_CurrentMenuItem.MenuItemSelected();
                }

                io_CurrentMenuItem = io_CurrentMenuItem.PreviousMenuItem;
            }
        }

        private MenuItem getUserSelectedMenuItem(SubMenuItem i_CurrentMenuItem)
        {
            int userChoice;
            int maxMenuValue = i_CurrentMenuItem.SubMenuItems.Count - 1;
            string wrongInputMsg = string.Format("Invaild input, let's try again. Please enter a number between {0} to {1} only: ",
                k_MinMenuValue, maxMenuValue);

            i_CurrentMenuItem.Show();
            Console.Write("Your choice is: ");

            if (int.TryParse(Console.ReadLine(), out userChoice) == true)
            {
                while (userChoice < k_MinMenuValue || userChoice > maxMenuValue)
                {
                    userChoice = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                throw new FormatException("String did not succeed parsed to an integer!");
            }

            return i_CurrentMenuItem.SubMenuItems[userChoice];
        }
    }
}
