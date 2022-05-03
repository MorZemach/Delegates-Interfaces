namespace Ex04.Menus.Interfaces
{
    using System;

    public class ActionMenuItem : MenuItem
    {
        // $G$ CSS-999 (-3) This kind of field should be readonly.
        private INotifierToExecuteMenuItem m_ExecuteSelectedItem;

        public ActionMenuItem(string i_ItemName, MenuItem i_MenuItem = null, INotifierToExecuteMenuItem i_ExecuteItem = null)
            : base(i_ItemName, i_MenuItem)
        {
            m_ExecuteSelectedItem = i_ExecuteItem;
        }

        public override void MenuItemSelected()
        {
            ActionMenuItemSelected();
        }

        public void ActionMenuItemSelected()
        {
            if (m_ExecuteSelectedItem == null)
            {
                throw new Exception("Method is not exist!");
            }
            else
            {
                m_ExecuteSelectedItem.ExecuteSelectedMenuItem();
            }
        }
    }
}
