namespace Ex04.Menus.Test
{
    using System;
    using Ex04.Menus.Interfaces;

    public class ShowVersion : INotifierToExecuteMenuItem
    {
        public static void ShowVersionMethod()
        {
            Console.WriteLine(string.Format("Version: 21.1.4.8930{0}", Environment.NewLine));
        }

        void INotifierToExecuteMenuItem.ExecuteSelectedMenuItem()
        {
            ShowVersionMethod();
        }
    }
}
