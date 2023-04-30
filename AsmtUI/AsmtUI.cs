using AsmtLib;


namespace AssessmentUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome();
            UI();

        }

        private static void Welcome()
        {
            Console.WriteLine("Welcome to Assessment-1 of C#");
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();

            // Console.WriteLine($"{Greeting()}, {name}");
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
            string[] tasks = new string[9]
            {
                "Largest Number in a list",
                "Reverse list in place",
                "Check if value is in list",
                "Return elements in odd position of list",
                "Running total of a list",
                "Is string a palindrome",
                "Sum of numbers in list (for)",
                "Sum of numbers in list (while)",
                "Sum of numbers in list (method)"
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
                Lib.LargestNumber();
                ReDo();
            }
            else if (choice == "2")
            {
                Lib.RevList();
                ReDo();
            }
            else if (choice == "3")
            {
                Lib.ChkList();
                ReDo();
            }
            else if (choice == "4")
            {
                Lib.OddPosElems();
                ReDo();
            }
            else if (choice == "5")
            {
                Lib.TotalNum();
                ReDo();
            }
            else if (choice == "6")
            {
                // Lib.Palindrome();
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










