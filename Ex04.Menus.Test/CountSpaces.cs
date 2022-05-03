namespace Ex04.Menus.Test
{
    using System;
    using Ex04.Menus.Interfaces;

    public class CountSpaces : INotifierToExecuteMenuItem
    {
        public static void CountSpacesInSentence()
        {
            string userSentence = null;
            int numberOfSpacesInSentence = 0;

            Console.WriteLine("Please enter a sentence:");
            userSentence = Console.ReadLine();
            foreach (char character in userSentence)
            {
                if(char.IsWhiteSpace(character) == true)
                {
                    numberOfSpacesInSentence++;
                }
            }

            Console.WriteLine(string.Format(@"There are {0} spaces in the sentence.{1}", numberOfSpacesInSentence, Environment.NewLine));
        }

        void INotifierToExecuteMenuItem.ExecuteSelectedMenuItem()
        {
            CountSpacesInSentence();
        }
    }
}
