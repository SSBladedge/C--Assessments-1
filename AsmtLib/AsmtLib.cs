using System.Text.RegularExpressions;

//Rename the methods below 
namespace AsmtLib
{
    public class Lib
    {
        private static List<int> GetList()
        {
            Console.WriteLine("Please input 5 digits for your list");
            List<int> userInts = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                string? userVal = Console.ReadLine();
                int userInt;
                if (int.TryParse(userVal, out userInt))
                    userInts.Add(userInt);
            }
            return userInts;
        }

        public static void LargestNumber()
        {

            List<int> arr = GetList();
            if (arr == null || arr.Count == 0)
            {
                Console.WriteLine("Please add values to the list");
            }

            else
            {
                int largest = arr[0];

                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] >= largest)
                        largest = arr[i];
                }

                Console.WriteLine($"Largest is {largest}");
            }
        }

        public static void ReverseList()
        {
            List<int> arr = GetList();
            if (arr == null || arr.Count == 0)
            {
                Console.WriteLine("Please add values to the list");
            }

            else
            {
                int c = arr.Count;
                for (int i = 0; i < c / 2; i++)
                {
                    int temp = arr[i];
                    arr[i] = arr[c - i - 1];
                    arr[c - i - 1] = temp;
                }
                Console.WriteLine(String.Join(',', arr));
            }
        }

        public static void CheckList()
        {
            //FOR USERS - REPLACE GETLIST() BELOW WITH A COPY OF THE DESIRED LIST TO PARSE THROUGH

            List<int> arr = GetList();
            if (arr == null || arr.Count == 0)
            {
                Console.WriteLine("Please add values to the list");
            }

            else
            {
                Console.WriteLine("Please enter a value to search for in the list: ");
                int intVal = Convert.ToInt32(Console.ReadLine());
                bool found = false;

                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] == intVal)
                    {
                        found = true;
                        break;
                    }
                }
                if (found == true)
                    Console.WriteLine("We found your input!!");
                else
                    Console.WriteLine("We could not find your input");
            }
        }

        public static void ElementsInOddPosition()
        {

            List<int> arr = GetList();
            if (arr == null || arr.Count == 0)
            {
                Console.WriteLine("Please add values to the list");
            }

            else
            {
                List<int> oddList = new List<int>();
                for (int i = 0; i < arr.Count; i++)
                {
                    oddList.Add(arr[i]);
                    i++;
                }
                Console.WriteLine(String.Join(',', oddList));
            }
        }

        public static void TotalNumber()
        {

            List<int> arr = GetList();
            if (arr == null || arr.Count == 0)
            {
                Console.WriteLine("Please add values to the list");
            }

            else
            {
                int total = 0;
                for (int i = 0; i < arr.Count; i++)
                    total++;
                Console.WriteLine($"Total is {total}");
            }
        }

        public static void Palindrome()
        {
            Console.WriteLine("Please input a string for analysis: ");
            string? input = Console.ReadLine();

            if (input != null)
            {
                string noSpace = Regex.Replace(input, @"\s+", "");
                bool isPalindrome = true;
                int l = noSpace.Length;
                int r = (l % 2 == 0) ? l / 2 : Convert.ToInt32(Math.Floor(Convert.ToDecimal(l / 2)));

                for (int i = 0; i < r; i++)
                {
                    // if (!char.Equals(noSpace[i], noSpace[l - i - 1], StringComparison.OrdinalIgnoreCase)) //Complete the if statement
                    if (noSpace[i] != noSpace[l - i - 1])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome)
                    Console.WriteLine("Your statement was a palindrome");
                else
                    Console.WriteLine("Your statement was not a palindrome");
            }
        }

        public static void SumWithFor()
        {
            List<int> arr = GetList();
            if (arr == null || arr.Count == 0)
            {
                Console.WriteLine("Please add values to the list");
            }

            else
            {
                int total = 0;
                for (int i = 0; i < arr.Count; i++)
                    total += arr[i];
                Console.WriteLine($"Total is {total}");
            }
        }

        public static void SumWithWhile()
        {
            List<int> arr = GetList();
            if (arr == null || arr.Count == 0)
            {
                Console.WriteLine("Please add values to the list");
            }

            else
            {
                int i = 0;
                int total = 0;

                while (i < arr.Count)
                {
                    total += arr[i];
                    i++;
                }
                Console.WriteLine($"Total is {total}");
            }
        }

        public static void SumWithMethod()
        {
            List<int> arr = GetList();
            if (arr == null || arr.Count == 0)
            {
                Console.WriteLine("Please add values to the list");
            }

            else
                Console.WriteLine(arr.AsQueryable().Sum());
        }


        public static void GuessTheNumber()
        {
            int maxNum = 20;            //Difficulty setting 
            Random rnd = new Random();
            int rndNum = rnd.Next(maxNum + 1);
            int guess = GuessUI(maxNum);

            GameSetup(guess, rndNum, maxNum);
        }


        private static void GameSetup(int guessVal, int actualVal, int max)
        {
            int currentProg = 0;
            int lastProg = 0;
            bool gameIsRunning = true;

            while (gameIsRunning)
            {
                if (guessVal == actualVal)
                {
                    Console.WriteLine("CONGRATS, YOU WON!!");
                    gameIsRunning = false;
                }
                else
                {
                    lastProg = currentProg;
                    currentProg = Math.Abs(guessVal - actualVal);

                    // if (guessVal > actualVal)
                    // {
                    //     Console.WriteLine("Too high");
                    //     guessVal = GuessUI(max);
                    // }
                    // else{
                    //     Console.WriteLine("Too low");
                    //     guessVal = GuessUI(max);
                    // }

                    if (currentProg == lastProg)
                    {
                        Console.WriteLine("No progress yet");
                        guessVal = GuessUI(max);

                    }

                    else if (currentProg > lastProg)
                    {
                        Console.WriteLine("Getting colder");
                        guessVal = GuessUI(max);
                    }

                    else
                    {
                        Console.WriteLine("Getting warmer");
                        guessVal = GuessUI(max);
                    }
                }
            }
        }

        private static int GuessUI(int maxNum)
        {
            int checkedInput = 0;

            while (true)
            {
                checkedInput = GuessChecker(maxNum);
                if (checkedInput >= 0)
                    break;
                else
                    Console.WriteLine(ErrorMessage(checkedInput));
            }
            return checkedInput;
        }

        private static int GuessChecker(int max)
        {
            Console.WriteLine($"Guess a number inclusively between 0 and {max}: ");
            string? input = Console.ReadLine();
            int guess;


            //Below can be reduced to a terniary operation 
            if (int.TryParse(input, out guess))
            {
                if (guess < 0 || guess > max)
                {
                    return -5;
                }
                else
                {
                    return guess;
                }
            }
            else
            {
                return -3;
            }
        }


        private static string ErrorMessage(int errCode)
        {
            if (errCode == -3)
            {
                Console.Clear();
                return ("Please use a 32-bit number");
            }
            else
            {
                Console.Clear();
                return ("number needs to be between 0 and 20");
            }
        }
    }
}


