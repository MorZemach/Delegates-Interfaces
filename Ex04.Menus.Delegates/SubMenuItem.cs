namespace Ex04.Menus.Delegates
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SubMenuItem : MenuItem
    {
        private const byte k_ExitOrBackChoiceIndex = 0;
        private readonly List<MenuItem> r_SubMenuItems;

        public SubMenuItem(string i_MenuItemName, SubMenuItem i_PreviousMenuItem = null) :
            base(i_MenuItemName, i_PreviousMenuItem)
        {
            r_SubMenuItems = new List<MenuItem>();
        }

        public List<MenuItem> SubMenuItems
        { 
            get { return r_SubMenuItems; } 
        }

        public override void MenuItemSelected()
        {
            Show();
        }

        public override void Show()
        {
            StringBuilder currentSubMenuToPresent = new StringBuilder();

            base.Show();
            addSubMenuboundary(ref currentSubMenuToPresent);
            currentSubMenuToPresent.AppendLine(string.Format("{0}Please select one of the following menu option or {1} to {2}:",
                  Environment.NewLine, k_ExitOrBackChoiceIndex, r_SubMenuItems[k_ExitOrBackChoiceIndex].MenuItemName));
            addSubMenuItemsName(ref currentSubMenuToPresent);
            addSubMenuboundary(ref currentSubMenuToPresent);
            Console.WriteLine(currentSubMenuToPresent);
        }

        private void addSubMenuItemsName(ref StringBuilder io_CurrentSubMenuToPresent)
        {
            for (int index = 1; index < r_SubMenuItems.Count; index++)
            {
                io_CurrentSubMenuToPresent.AppendLine(string.Format("{0}. {1}", index, r_SubMenuItems[index].MenuItemName));
            }

            io_CurrentSubMenuToPresent.AppendLine(string.Format("{0}. {1}",
               k_ExitOrBackChoiceIndex, r_SubMenuItems[k_ExitOrBackChoiceIndex].MenuItemName));
        }

        private void addSubMenuboundary(ref StringBuilder io_CurrentSubMenuToPresent)
        {
            io_CurrentSubMenuToPresent.Append("******************************************************");
        }

        public void AddItemToSubMenu(MenuItem i_MenuItemToAdd)
        {
            SubMenuItems.Add(i_MenuItemToAdd);
        }

        public void RemoveItemFromSubMenu(MenuItem i_MenuItemToRemove)
        {
            SubMenuItems.Remove(i_MenuItemToRemove);
        }
    }
}
