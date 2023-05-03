using AsmtLib;


namespace AssessmentUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            UI();

        }

        private static void Welcome()
        {
            Console.WriteLine("Welcome to Assessment-1 of C#");
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("{0}, {1}", Greeting(), name);
        }

        private static string Greeting()
        {
            int hrOfDay = DateTime.Now.Hour;

            if (hrOfDay < 12)
                return "Good morning";
            else if (hrOfDay >= 12 && hrOfDay < 17)
                return "Good afternoon";
            else
                return "Good evening";
        }

        private static void UI()
        {
            string[] tasks = new string[10]
            {
                "Largest Number in a list",
                "Reverse list in place",
                "Check if value is in list",
                "Return elements in odd position of list",
                "Running total of a list",
                "Is string a palindrome",
                "Sum of numbers in list (for)",
                "Sum of numbers in list (while)",
                "Sum of numbers in list (method)",
                "Guess the number!"
            };

            Console.WriteLine("Please select from the available options below:");

            for (int i = 0; i < tasks.Length; i++)
            {
                int num = i + 1;
                Console.WriteLine("{0} - {1}", num, tasks[i]);
            }

            Console.WriteLine("What option will you choose?");
            string? choice = Console.ReadLine();


            if (choice == "1")
            {
                Console.Clear();
                Lib.LargestNumber();
                ReDo();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Lib.ReverseList();
                ReDo();
            }
            else if (choice == "3")
            {
                Console.Clear();
                Lib.CheckList();
                ReDo();
            }
            else if (choice == "4")
            {
                Console.Clear();
                Lib.ElementsInOddPosition();
                ReDo();
            }
            else if (choice == "5")
            {
                Console.Clear();
                Lib.TotalNumber();
                ReDo();
            }
            else if (choice == "6")
            {
                Console.Clear();
                Lib.Palindrome();
                ReDo();
            }
            else if (choice == "7")
            {
                Console.Clear();
                Lib.SumWithFor();
                ReDo();
            }
            else if (choice == "8")
            {
                Console.Clear();
                Lib.SumWithWhile();
                ReDo();
            }
            else if (choice == "9")
            {
                Console.Clear();
                Lib.SumWithMethod();
                ReDo();
            }
            else if (choice == "10")
            {
                Console.Clear();
                Lib.GuessTheNumber();
                ReDo();
            }
        }

        private static void ReDo()
        {
            Console.WriteLine("would you like to go again? (Y/N)");
            string? choice = Console.ReadLine()!;
            string theChoice = choice.ToUpper();
            if (theChoice == "Y")
            {
                Console.Clear();
                UI();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Thank you for your time");
            }

        }
    }
}










