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
                    // {
                    //     isPalindrome = false;
                    //     break;
                    // }
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
            int maxNum = 20;          //Difficulty setting 
            Random rnd = new Random();
            int rndNum = rnd.Next(maxNum + 1);

            bool repeat = true;
            int checkInput = 0;


            while (repeat)
            {
                checkInput = GuessChecker(maxNum);
                if (checkInput >= 0)
                {
                    Console.WriteLine($"Guessed number is {checkInput}");
                    Console.WriteLine("It is valid");
                    repeat = false;
                }
                else if (checkInput == -3)
                {
                    Console.Clear();
                    Console.WriteLine("Please use a 32-bit number");
                }
                else if (checkInput == -5)
                {
                    Console.Clear();
                    Console.WriteLine("number needs to be between 0 and 20");
                }
            }
            Console.WriteLine($"This is final number: {checkInput}");
            // int currentProg;
            // int lastProg;
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
    }
}


