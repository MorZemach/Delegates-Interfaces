namespace Ex04.Menus.Test
{
    using System;
    using Ex04.Menus.Interfaces;

    public class ShowDate : INotifierToExecuteMenuItem
    {
        public static void ShowDateMethod()
        {
            Console.WriteLine(string.Format("Today's date is: {0:dd/MM/yyyy}.{1}", DateTime.Now.Date, Environment.NewLine)); 
        }

        void INotifierToExecuteMenuItem.ExecuteSelectedMenuItem()
        {
            ShowDateMethod();
        }
    }
}
