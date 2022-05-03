namespace Ex04.Menus.Delegates
{
    using System;

    public abstract class MenuItem
    {
        private MenuItem m_PreviousMenuItem;
        private string m_MenuItemName;

        public MenuItem(string i_MenuItemName, MenuItem i_PreviousMenuItem)
        {
            PreviousMenuItem = i_PreviousMenuItem;
            MenuItemName = i_MenuItemName;
        }

        public MenuItem PreviousMenuItem
        {
            get { return m_PreviousMenuItem; }
            set { m_PreviousMenuItem = value; }
        }

        public string MenuItemName
        {
            get { return m_MenuItemName; }
            set { m_MenuItemName = value; }
        }

        public virtual void Show()
        {
            Console.WriteLine(m_MenuItemName);
        }

        public abstract void MenuItemSelected();
    }
}
