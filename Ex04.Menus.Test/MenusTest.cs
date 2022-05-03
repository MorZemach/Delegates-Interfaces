namespace Ex04.Menus.Test
{
    using System;

    public class MenusTest
    {
        private static Interfaces.MainMenu m_InterfacesMenu;
        private static Delegates.MainMenu m_DelegatesMenu;

        public static void ActivatingTestMenus()
        {
            activatingInterfacesMenu();
            activatingDelegateMenu();
            Console.WriteLine("Have a great day!");
        }

        private static void activatingInterfacesMenu()
        {
            m_InterfacesMenu = new Interfaces.MainMenu("Interface Menu");
            createInterfacesMenu();
            m_InterfacesMenu.Show();
        }

        private static void createInterfacesMenu()
        {
            Interfaces.ActionMenuItem exitItem = new Interfaces.ActionMenuItem("Exit");
            m_InterfacesMenu.Menu.AddItemToSubMenu(exitItem);
            Interfaces.SubMenuItem versionAndSpacesSubMenu = new Interfaces.SubMenuItem("Version and Spaces", m_InterfacesMenu.Menu);
            Interfaces.ActionMenuItem backItemVersionAndSpacesSubMenu = new Interfaces.ActionMenuItem("Back", versionAndSpacesSubMenu.PreviousMenuItem);
            Interfaces.INotifierToExecuteMenuItem showVersion = new ShowVersion();
            Interfaces.ActionMenuItem showVersionActionItem = new Interfaces.ActionMenuItem("Show Version", versionAndSpacesSubMenu, showVersion);
            Interfaces.INotifierToExecuteMenuItem countSpaces = new CountSpaces();
            Interfaces.ActionMenuItem countSpacesActionItem = new Interfaces.ActionMenuItem("Count Spaces", versionAndSpacesSubMenu, countSpaces);
            versionAndSpacesSubMenu.AddItemToSubMenu(backItemVersionAndSpacesSubMenu);
            versionAndSpacesSubMenu.AddItemToSubMenu(showVersionActionItem);
            versionAndSpacesSubMenu.AddItemToSubMenu(countSpacesActionItem);
            m_InterfacesMenu.Menu.AddItemToSubMenu(versionAndSpacesSubMenu);
            Interfaces.SubMenuItem showDateOrTimeSubMenu = new Interfaces.SubMenuItem("Show Date / Time", m_InterfacesMenu.Menu);
            Interfaces.ActionMenuItem backItemShowDateOrTimeSubMenu = new Interfaces.ActionMenuItem("Back", showDateOrTimeSubMenu.PreviousMenuItem);
            Interfaces.INotifierToExecuteMenuItem showTime = new ShowTime();
            Interfaces.ActionMenuItem showTimeActionItem = new Interfaces.ActionMenuItem("Show Time", showDateOrTimeSubMenu, showTime);
            Interfaces.INotifierToExecuteMenuItem showDate = new ShowDate();
            Interfaces.ActionMenuItem showDateActionItem = new Interfaces.ActionMenuItem("Show Date", showDateOrTimeSubMenu, showDate);
            showDateOrTimeSubMenu.AddItemToSubMenu(backItemShowDateOrTimeSubMenu);
            showDateOrTimeSubMenu.AddItemToSubMenu(showTimeActionItem);
            showDateOrTimeSubMenu.AddItemToSubMenu(showDateActionItem);
            m_InterfacesMenu.Menu.AddItemToSubMenu(showDateOrTimeSubMenu);
        }

        private static void activatingDelegateMenu()
        {
            m_DelegatesMenu = new Delegates.MainMenu("Delegate Menu");
            createDelegatesMenu();
            m_DelegatesMenu.Show();
        }

        private static void createDelegatesMenu()
        {
            Delegates.ActionMenuItem exitItem = new Delegates.ActionMenuItem("Exit");
            m_DelegatesMenu.Menu.AddItemToSubMenu(exitItem);
            Delegates.SubMenuItem versionAndSpacesSubMenu = new Delegates.SubMenuItem("Version ans Spaces", m_DelegatesMenu.Menu);
            Delegates.ActionMenuItem backItemVersionAndSpacesSubMenu = new Delegates.ActionMenuItem("Back", versionAndSpacesSubMenu.PreviousMenuItem);
            Delegates.ActionMenuItem showVersion = new Delegates.ActionMenuItem("Show Version", versionAndSpacesSubMenu);
            showVersion.EventHandlerOfExecuteMenuItem += ShowVersion.ShowVersionMethod;
            Delegates.ActionMenuItem countSpacesActionItem = new Delegates.ActionMenuItem("Count Spaces", versionAndSpacesSubMenu);
            countSpacesActionItem.EventHandlerOfExecuteMenuItem += CountSpaces.CountSpacesInSentence;
            versionAndSpacesSubMenu.AddItemToSubMenu(backItemVersionAndSpacesSubMenu);
            versionAndSpacesSubMenu.AddItemToSubMenu(showVersion);
            versionAndSpacesSubMenu.AddItemToSubMenu(countSpacesActionItem);
            m_DelegatesMenu.Menu.AddItemToSubMenu(versionAndSpacesSubMenu);
            Delegates.SubMenuItem showDateOrTimeSubMenu = new Delegates.SubMenuItem("Show Date / Time", m_DelegatesMenu.Menu);
            Delegates.ActionMenuItem backItemShowDateOrTimeSubMenu = new Delegates.ActionMenuItem("Back", showDateOrTimeSubMenu.PreviousMenuItem);
            Delegates.ActionMenuItem showTimeActionItem = new Delegates.ActionMenuItem("Show Time", showDateOrTimeSubMenu);
            showTimeActionItem.EventHandlerOfExecuteMenuItem += ShowTime.ShowTimeMethod;
            Delegates.ActionMenuItem showDateActionItem = new Delegates.ActionMenuItem("Show Date", showDateOrTimeSubMenu);
            showDateActionItem.EventHandlerOfExecuteMenuItem += ShowDate.ShowDateMethod;
            showDateOrTimeSubMenu.AddItemToSubMenu(backItemShowDateOrTimeSubMenu);
            showDateOrTimeSubMenu.AddItemToSubMenu(showTimeActionItem);
            showDateOrTimeSubMenu.AddItemToSubMenu(showDateActionItem);
            m_DelegatesMenu.Menu.AddItemToSubMenu(showDateOrTimeSubMenu);
        }
    }
}
