namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            int[] numbers = new int[10];
            ReadNumbers(numbers);
            Console.Write("Enter a search value: ");
            int searchValue = int.Parse(Console.ReadLine());
            int count = CountSearchValue(numbers, searchValue);
            Console.WriteLine($"Number of occurrences of search value ({searchValue}) is: {count}");
        }
        void ReadNumbers(int[] numbers)
        {
            int counter = 0;
            while (counter < numbers.Length)
            {
                Console.Write("Enter a number (0=stop): ");
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                numbers[counter] = number;
                counter++;
            }
        }

        int CountSearchValue(int[] numbers, int searchValue)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchValue)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
