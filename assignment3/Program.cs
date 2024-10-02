namespace assignment3
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
            int[] numbers = new int[3];
            Console.WriteLine("Enter 3 integers: ");
            FillArray(numbers);
            Console.WriteLine(CalculateSum(numbers));
            Console.WriteLine(CalculateAverage(numbers));
        }
        void FillArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
        int CalculateSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        double CalculateAverage(int[] numbers)
        {
            return CalculateSum(numbers) / 3;
        }
    }
}
