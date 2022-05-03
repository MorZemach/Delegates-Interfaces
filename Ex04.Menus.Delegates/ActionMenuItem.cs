namespace Ex04.Menus.Delegates
{
    using System;

    public class ActionMenuItem : MenuItem
    {
        // $G$ CSS-021 (-3) should not contain EventHandler in the name of the public event
        public event Action EventHandlerOfExecuteMenuItem;

        public ActionMenuItem(string i_MenuItemName, MenuItem i_PreviousMenuItem = null) :
            base(i_MenuItemName, i_PreviousMenuItem)
        {
        }

        public override void MenuItemSelected()
        {
            OnActionMenuItemSelected();
        }

        protected virtual void OnActionMenuItemSelected()
        {
            if (EventHandlerOfExecuteMenuItem != null)
            {
                EventHandlerOfExecuteMenuItem();
            }
            else
            {
                throw new Exception("Method is not exist!");
            }
        }
    }
}
