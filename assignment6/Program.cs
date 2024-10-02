namespace assignment6
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
            int[] counts = { 0, 0, 0, 0, 0, 0 };
            Random random = new Random();
            for (int i = 1; i <= 6000; i++)
            {
                int number = random.Next(1, 7);
                counts[number - 1]++;

            }
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(counts[i]);
            }
        }
    }
}
