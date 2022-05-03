namespace Ex04.Menus.Test
{
    using System;
    using Ex04.Menus.Interfaces;

    public class ShowTime : INotifierToExecuteMenuItem
    {
        public static void ShowTimeMethod()
        {
            Console.WriteLine(string.Format("The local time now is: {0:HH:mm:ss}.{1}", DateTime.Now, Environment.NewLine));
        }

        void INotifierToExecuteMenuItem.ExecuteSelectedMenuItem()
        {
            ShowTimeMethod();
        }
    }
}
