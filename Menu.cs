using System;
using System.Collections.Generic;


namespace ConsoleAppTask
{
    class Menu
    {
        MenuItems items = new MenuItems();  //Hold the main menu info
        FunctionManager functions = new FunctionManager();  //Where most tasks are managed
        

        // Shows the basic menu options
        public void ShowMainMenu()
        {
            Console.WriteLine("Hello user, welcome to the main menu!\n");
            items.FunctionItems();
            Console.WriteLine("\nWhat function do you want to start?");
        }

        //Starts the different functions based on what was picked.
        public bool StartPickedFunction(string menuChose)
        {
            int option;

            //Try to parse the input string to int
            if (!Int32.TryParse(menuChose, out option)) //If the parse didn't work, return to main loop and ask again
            {
                Console.WriteLine("Press a key to retry!");
                Console.ReadKey();
                return true;
            }

            Console.Clear();

            //Checks what was picked and starts that function (if it exists), correspondence to the list of functions in the pdf
            switch (option)//pickedOption)
            {
                case 0: //Exit Option
                    Console.WriteLine("\nYou have choosen to exit the program, are you sure Y or N?");    //Asks again to make sure
                    string yesOrNo = Console.ReadLine();
                    if (yesOrNo == "Y")     //Y returns true witch stops the program
                        return false;
                     else                    //Anything else is taken as a no
                        return true;
                case 1:
                    Console.WriteLine("Function 1 is starting!\n");
                    functions.FunctionOne();
                    break;
                case 2:
                    Console.WriteLine("Function 2 is starting!\n");
                    functions.FunctionTwo();
                    break;
                case 3:
                    Console.WriteLine("Function 3 is starting!\n");
                    functions.FunctionThree();
                    break;
                case 4:
                    Console.WriteLine("Function 4 is starting!\n");
                    functions.FunctionFour();
                    break;
                case 5:
                    Console.WriteLine("Function 5 is starting!\n");
                    functions.FunctionFive();
                    break;
                case 6:
                    Console.WriteLine("Function 6 is starting!\n");
                    functions.FunctionSix();
                    break;
                case 7:
                    Console.WriteLine("Function 7 is starting!\n");

                    if (functions.FunctionSeven())
                        Console.WriteLine("\nSaved file successfully!");
                    break;
                case 8:
                    Console.WriteLine("Function 8 is starting!\n");

                    if (functions.FunctionEight())
                        Console.WriteLine("\nRead from file successfully!");
                    break;
                case 9:
                    Console.WriteLine("Function 9 is starting!\n");
                    functions.FunctionNine();
                    break;
                case 10:
                    Console.WriteLine("Function 10 is starting!\n");

                    functions.FunctionTen();
                    break;
                case 11:
                    Console.WriteLine("Function 11 is starting!\n");

                    functions.FunctionEleven();
                    break;
                case 12:
                    Console.WriteLine("Function 12 is starting!\n");

                    functions.FunctionTwelve();
                    break;
                case 13:
                    Console.WriteLine("Function 13 is starting!\n");

                    functions.FunctionThirteen();
                    break;
                case 14:
                    Console.WriteLine("Function 14 is starting!\n");

                    functions.FunctionFourteen();
                    break;
                case 15:
                    Console.WriteLine("Function 15 is starting!\n");

                    functions.FunctionFifteen();
                    break;
                case 16:
                    Console.WriteLine("Function 16 is starting!\n");

                    functions.FunctionSixteen();
                    break;
                default:    //If the chosen number didn't corresponded to a function
                    Console.WriteLine("You did not pick a valid menu option!");
                    break;
            }

            Console.WriteLine("\nPress any key to try again!");
            Console.ReadKey();

            return true;
        }
    }

    /// <summary>
    /// Holds what every function does and writes it all out to the console
    /// </summary>
    class MenuItems
    {
        private List<string> items = new List<string>();    //Holds what each function does
        
        public MenuItems()
        {
            items.Add("0: Exits the program."); //0
            items.Add("1: Writes out Hello World."); //1
            items.Add("2: User inputs a name and age then the function then prints it out again."); //2
            items.Add("3: Switches cmd text color, run again to change back."); //3
            items.Add("4: Prints out todays date."); //4
            items.Add("5: User inputs two integer values, then gets the larger value back."); //5
            items.Add("6: Randomizes a value between 1-100, user then guesses the value."); //6
            items.Add("7: User inputs a line as input, that is then saved to a file."); //7
            items.Add("8: Reads the file from function 7 then writes it out on the cmd."); //8
            items.Add("9: User inputs a decimal value, then gets back the square root of, raised to 2 and 10 as output."); //9
            items.Add("10: Outputs multiplication tables 1 through 10."); //10
            items.Add("11: Fylls an array with randomized values, then fylls a second one with same values but raised order "); //11
            items.Add("12: Checks if the users input is an palindrom"); //12
            items.Add("13: User inputs two integer values, all the values between the chosen values are written out."); //13
            items.Add("14: User inputs in a bunch of integer values(seprate each value with a comma), all the values are then orginized between odd & even and written out"); //14
            items.Add("15: User inputs in a bunch of integer values(seprate each value with a comma), all of them are added together and then written out"); //15
            items.Add("16: User inputs a name for both their character and an enemy, hp, str and luck are randomized for both and saved on a file."); //16
        }

        //Prints it all out
        public void FunctionItems() 
        {
            foreach (string item in items)
                Console.WriteLine(item);
        }
    }
}
