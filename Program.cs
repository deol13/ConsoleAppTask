using System;

/// <summary>
/// Dennis Olsen
/// </summary>

namespace ConsoleAppTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            //Put the mainloop here
            bool continueLooping = true;
            //Continues to keep the program going as long as exit option hasn't been chosen
            while (continueLooping)
            {
                Console.Clear();

                menu.ShowMainMenu();                //Show the menu
                string input = Console.ReadLine();  //Collect the choosen menu option
                continueLooping = menu.StartPickedFunction(input); //Start the chosen function
            }

        }
    }
}
