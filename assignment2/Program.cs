namespace assignment2
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
            int[] numbers = new int[20];
            FillArray(numbers);
            DisplayNumbers(numbers);
            Console.WriteLine($"\nThe smallest number is: {GetSmallestNumber(numbers)}");
        }
        void FillArray(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }

        }

        void DisplayNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        int GetSmallestNumber(int[] numbers)
        {
            int smallest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            return smallest;
        }
    }
}
