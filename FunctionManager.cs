using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleAppTask
{
    class FunctionManager
    {
        private string fileName = "fileUsedInTasks.txt";
       
        //Task one, writes out Hellow World to the cmd
        public void FunctionOne()
        {
            Console.WriteLine("Hello World!");
        }

        //Task two, takes a line as input and writes it out again
        public void FunctionTwo()
        {
            Console.WriteLine("Input a first name, last name and age!");
            string input = Console.ReadLine();
            Console.WriteLine(input);
        }

        //If the text color in cmd isn't magenta, change it to magenta, if it is change it to white
        public void FunctionThree()
        {
            //Check if the text color already is magenta, below 0 answer indicate that it is not.
            if (Console.ForegroundColor.CompareTo(ConsoleColor.Magenta) < 0)
                Console.ForegroundColor = ConsoleColor.Magenta; //Below 0 and it ends up here
            else
                Console.ForegroundColor = ConsoleColor.White; //Above and it ends up here
        }

        //Write out todays date
        public void FunctionFour()
        {
            Console.WriteLine(DateTime.Now);
        }

        //Write the bigger of two inputted values
        public void FunctionFive()
        {
            int valueOne = 0;
            int valueTwo = 0;
            bool workingInput = false;
            bool workingInput2 = false;

            //Incase user writes a non integer input the function keeps asking instead of quitting
            while (!workingInput || !workingInput2)
            {
                Console.WriteLine("Input two integer values");
                string input = Console.ReadLine();
                string[] result = input.Split();  //Splits the input into an array

                if (result.Length == 2)
                {
                    //Change string to integer
                    workingInput = Int32.TryParse(result[0], out valueOne);
                    workingInput2 = Int32.TryParse(result[1], out valueTwo);

                    if (workingInput && workingInput2)
                    {
                        //Check which value is larger
                        if (valueOne >= valueTwo)
                        {
                            Console.WriteLine(valueOne);
                        }
                        else
                        {
                            Console.WriteLine(valueTwo);
                        }
                    }
                    else
                        Console.WriteLine("Error: Invalid input, only integers allowed!\n");
                }
                else
                    Console.WriteLine("Either too many or not enough values!\n"); //If input contains below or above 2 values
            }
        }

        //User has to guess a randomized value between 1 and 100
        public void FunctionSix()
        {
            Random rnd = new Random();

            int randValue = rnd.Next(1, 100); //Rand a value
            int value;
            bool workingInput = true;

            while (workingInput) //Continue to loop until correct answer has been given
            {
                Console.WriteLine("Input an integer as a guess!");
                string input = Console.ReadLine();
                string[] inputArray = input.Split();

                if (inputArray.Length == 1)
                {
                    workingInput = Int32.TryParse(input, out value);

                    if (workingInput) //If the transformation didn't work, ask after a new guess
                    {
                        Console.WriteLine("");

                        //Gives a hint if the answer wasn't correct
                        if (randValue > value)
                            Console.WriteLine("Guessed value is too small a value!");
                        else if (randValue < value)
                            Console.WriteLine("Guessed value is too large a value!");
                        else
                        {
                            Console.WriteLine("You guessed correctly!");
                            workingInput = false;
                        }
                        Console.WriteLine("");
                    }
                    else
                        Console.WriteLine("Error: Invalid input, only integers allowed!\n");
                }
                else
                    Console.WriteLine("Error: Too many values, only one value allowed!\n");
            }
        }

        //Save a line of text from the user to file
        public bool FunctionSeven()
        {
            Console.WriteLine("Input a line of text you want saved to file.");
            string input = Console.ReadLine();

            //Incase an error occurs
            try
            {
                //We only have one line to write
                File.WriteAllText(fileName, input);
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to write to file, an error occured!\n");
                return false;
            }

            return true;
        }

        //Reads the saved file from function seven and outputs it to the user
        public bool FunctionEight()
        {
            string text = "";

            //Incase an error occurs
            try
            {
                //We only have one line to read
                text = File.ReadAllText(fileName);
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to read from file, an error occured!\n");
                return false;
            }

            Console.WriteLine(text);

            return true;
        }

        //Converts the string input to double then writes out its square root and when raised to the power of 2 & 10
        public void FunctionNine()
        {
            bool succeded = false;
            double value;

            while (!succeded)
            {
                Console.WriteLine("Input one decimal value (Use , when typing in the decimal value. For example 5,5)");
                Console.WriteLine("");
                string input = Console.ReadLine();
                string[] inputArray = input.Split();

                if (inputArray.Length == 1)
                {
                    //Convert the string input to a double
                    succeded = Double.TryParse(input, out value);

                    if (succeded)
                    {
                        //Writes out the result of square root of value
                        Console.WriteLine($"{input} square root is: {Math.Sqrt(value)}");

                        //Writes out the result of power raised to 2 of value
                        Console.WriteLine($"{input} raised to the power of 2 is: {Math.Pow(value, 2.0)}");

                        //Writes out the result of power raised to 10 of value
                        Console.WriteLine($"{input} raised to the power of 10 is: {Math.Pow(value, 10.0)}");
                    }
                    else
                        Console.WriteLine("Error: Invalid input, only integers or decimals allowed!\n");
                }
                else
                    Console.WriteLine("Error: Too many values, only input one value!\n");
            }
        }

        //Outputs a nice looking multiplication table, from table 1 through 10
        public void FunctionTen()
        {
            char pad = ' ';

            //Runs for each row (one row is one multiplication table)
            for (int i = 0; i < 10; i++) 
            {
                //Calcs each number in the current table, i+1 is current table
                for (int j = 1; j < 11; j++)
                {
                    int value = (i + 1) * j;    //Calculate the number
                    string str = value.ToString();  //Adds to a string

                    //Pads onto the string so it is 5 char big, to make the format nice 
                    Console.Write(str.PadRight(5, pad));

                    //End the line when done
                    if (j == 10)
                        Console.WriteLine("");
                }
            }
        }

        //Fills an array with random values, then fills a second array with those values but in a raised order
        public void FunctionEleven()
        {
            Random rnd = new Random();
            int randValue = rnd.Next(10, 20); //Rand the size of the arrays
            int maxValue = 50;

            //Both arrays
            int[] rndList = new int[randValue];
            int[] sortedList = new int[randValue];
            int[] tmp = new int[randValue];

            //Fills the first one with random values
            for (int i = 0; i < randValue; i++)
            {
                rndList[i] = rnd.Next(1, maxValue);
            }

            //Copy to a tmp array that we can change the contents as we need to
            rndList.CopyTo(tmp, 0);

            //Goes for each number in the rnd array
            for (int i = 0; i < randValue; i++)
            {
                //These two saves the smallest number and its index in the tmp array
                int smallestValue = maxValue + 1;
                int smallestIndex = 0;

                //Goes through the entire tmp array to find the smallest
                //Between each time this forloop is run, the smallest value is changed inside tmp array
                //To a value over max so its not used a second time
                for (int j = 0; j < randValue; j++)
                {
                    if (tmp[j] < smallestValue)
                    {
                        smallestValue = tmp[j];
                        smallestIndex = j;
                    }
                }

                //Here we put in the current smallest value in the sorted array
                sortedList[i] = smallestValue;
                //And we change current smallest value in tmp to a value over the max so its not used again
                tmp[smallestIndex] = maxValue+1;
            }

            Console.Write("Random array: ");
            HelpFunctions.WritingOutArray<int>(rndList);
            Console.Write("Sorted array: ");
            HelpFunctions.WritingOutArray<int>(sortedList);
        }

        //Reverts a word from user and checks if it is a palindrom or not
        //Could be solved very simple with sorting function in List
        public void FunctionTwelve()
        {
            bool approvedInput = false;

            while (!approvedInput)
            {
                Console.WriteLine("Type in a palindrom, only the alphabetic letters a-ö is acceptable!");
                string input = Console.ReadLine();

                string[] word = input.Split();
                string output = "";

                if (word.Length == 1)
                {
                    if ( !word[0].Any(x => !char.IsLetter(x)) )
                    {
                        //Convert the string to an char array so it can be parsed through by index
                        char[] charArray = word[0].ToCharArray();

                        //If there is any letters inside continue
                        if (charArray.Length > 0)
                        {
                            Console.WriteLine("");

                            //Go through the char array the reversed order to reverse the inputed word
                            for (int i = charArray.Length - 1; i >= 0; i--)
                            {
                                output += charArray[i];
                            }

                            //Then compare the new reversed word to see if it is a palindrom
                            if (output.Equals(word[0], StringComparison.CurrentCultureIgnoreCase))
                                Console.WriteLine(word[0] + " is a palindrom");
                            else
                                Console.WriteLine(word[0] + " is not a palindrom");

                            approvedInput = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nError: The input contains more then alphabetic letters!\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nError: The input contains more then one word!\n");
                }
            }
            
        }

        //Take two integer values as input then write out the values between the two.
        public void FunctionThirteen()
        {
            bool valueOrNot1 = false;
            bool valueOrNot2 = false;

            //Continues until acceptable values have been given
            while (!valueOrNot1 || !valueOrNot2)
            {
                Console.WriteLine("Input two integer values!");
                string input = Console.ReadLine();
                string[] inputArray = input.Split();

                //Only continues if two value have been given
                if (inputArray.Length == 2)
                {
                    int value1;
                    int value2;

                    //Continues only if both are values
                    if(Int32.TryParse(inputArray[0], out value1) && Int32.TryParse(inputArray[1], out value2))
                    {
                        //Checks which values is larger, so it sends correctly to the help function
                        if (value1 > value2)
                        {
                            Console.WriteLine("\nLarger value of the two: " + value1);
                            Console.WriteLine("Smaller value of the two: " + value2);

                            HelpFunctions.WriteOutAllValueBetween(value1, value2);
                        }
                        else
                        {
                            Console.WriteLine("\nLarger value of the two: " + value2);
                            Console.WriteLine("Smaller value of the two: " + value1);

                            HelpFunctions.WriteOutAllValueBetween(value2, value1);
                        }

                        valueOrNot1 = true;
                        valueOrNot2 = true;
                        Console.WriteLine("");
                    }
                    else
                        Console.WriteLine("Error: Invalid input, only integers allowed!\n");
                }
                else
                    Console.WriteLine("Error: You didn't input the correct number of values!\n");
            }
        }

        //Takes any number of integer values and sorts by even and odd into list and then prints it out
        public void FunctionFourteen()
        {
            char sep = ',';
            bool valueOrNot = false;
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();
            

            while (!valueOrNot)
            {
                int tmp = 0;

                Console.WriteLine("Input any number of integer values with a , between each.");
                string input = Console.ReadLine();
                string[] inputArray = input.Split(sep); //Splits by ,

                //For each string in inputArray we convert the string then check and adds them
                //to even or odd list
                foreach (string str in inputArray)
                {
                    if (!Int32.TryParse(str, out tmp)) //Not a value so we break out from the foreach
                    {
                        Console.WriteLine("Error: Invalid input, only integers allowed!\n");
                        break;
                    } 
                    else if(tmp %2 == 0) //Check for even or odd
                        evenList.Add(tmp);
                    else
                        oddList.Add(tmp);
                }
                
                if(valueOrNot)
                {
                    //Sorts
                    evenList.Sort();
                    oddList.Sort();

                    //Here we print out the list by using the foreach function in list and ToString
                    Console.Write("\nEven list: ");
                    evenList.ForEach(i => Console.Write(i.ToString() + ' '));

                    Console.Write("\nOdd list: ");
                    oddList.ForEach(i => Console.Write(i.ToString() + ' '));
                    Console.WriteLine("");

                    valueOrNot = true;
                }
            }
        }

        //Takes any number of integer values then adds them together and print out the total
        public void FunctionFifteen()
        {
            char sep = ',';
            bool valueOrNot = false;
            int totalValue = 0;

            while (!valueOrNot)
            {
                int tmp = 0;

                Console.WriteLine("Input any number of integer values with a , between each.");
                string input = Console.ReadLine();
                string[] inputArray = input.Split(sep); //Splits by ,

                //For each string in inputArray we convert the string and add them to the total
                foreach (string str in inputArray)
                {
                    valueOrNot = Int32.TryParse(str, out tmp);

                    if (!valueOrNot) //Not a value so we break out from the foreach
                    {
                        Console.WriteLine("Error: Invalid input, only integers allowed!\n");
                        break;
                    }
                    else //If it is a value, we add them to the total
                        totalValue += tmp;
                }

                //Print it all out if they were all values
                if (valueOrNot)
                    Console.WriteLine("\nThe total value: " + totalValue);
            }
        }

        //Take two names as input, creates two instances of the class Character
        //Randomizes values as data for Health, Strength and Luck
        public void FunctionSixteen()
        {
            Random rnd = new Random();

            Console.WriteLine("Type in the name of your character!");
            string yourName = Console.ReadLine();

            Console.WriteLine("Type in the name of your enemy's character!");
            string enemyName = Console.ReadLine();

            //Create two instanses of Character class to store all data
            Character you = new Character();
            Character enemy = new Character();

            //Create user's character, randomize the data
            you.Name = yourName;
            you.HP = rnd.Next(50, 150);
            you.Strength = rnd.Next(15, 40);
            you.Luck = rnd.Next(1, 10);

            //Create user's enemy's character, randomize the data
            enemy.Name = enemyName;
            enemy.HP = rnd.Next(50, 150);
            enemy.Strength = rnd.Next(15, 40);
            enemy.Luck = rnd.Next(1, 10);

            //Print it out with an custom ToString that overrides the default one
            Console.WriteLine("\nYour character: " + you.ToString());
            Console.WriteLine("Your enemy: " + enemy.ToString());
        }
    }
}
