namespace Ex04.Menus.Interfaces
{
    using System;

    public abstract class MenuItem
    {
        private MenuItem m_PreviousMenuItem;
        private string m_MenuItemName;

        public MenuItem(string i_ItemName, MenuItem i_PreviousMenuItem = null)
        {
            m_MenuItemName = i_ItemName;
            m_PreviousMenuItem = i_PreviousMenuItem;
        }

        public string MenuItemName
        {
            get { return m_MenuItemName; }
            set { m_MenuItemName = value; }
        }

        public MenuItem PreviousMenuItem
        {
            get { return m_PreviousMenuItem; }
            set { m_PreviousMenuItem = value; }
        }

        public virtual void Show()
        {
            Console.WriteLine(MenuItemName);
        }

        public abstract void MenuItemSelected();
    }
}
