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

        public static void RevList()
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

        public static void ChkList()
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
                string? inputVal = Console.ReadLine();
                int intVal = Convert.ToInt32(inputVal);
                bool found = false;

                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] == intVal)
                        found = true;
                }
                if (found == true)
                    Console.WriteLine("We found your input!!");
                else
                    Console.WriteLine("We could not find your input");
            }
        }

        public static void oddPosElems()
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
                    i += 1;
                }
                Console.WriteLine(String.Join(',', oddList));
            }
        }

        public static void totalNum()
        {

            List<int> arr = GetList();
            if (arr == null || arr.Count == 0)
            {
                Console.WriteLine("Please add values to the list");
            }

            else
            {

            }
        }

        public static void Palindrome()
        {
            Console.WriteLine("Please input a string for analysis: ");
            string? input = Console.ReadLine();


        }
    }
}


