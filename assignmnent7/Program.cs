namespace assignmnent7
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
            bool[] seats = new bool[10];
            InitializeSeats(seats);
            DisplaySeatingArrengement(seats);
            Console.WriteLine();
            Console.Write("Enter the seat number to book (1-10):");
            int seatNumber = int.Parse(Console.ReadLine());
            BookSeat(seats, seatNumber);
            DisplaySeatingArrengement(seats);

        }
        void InitializeSeats(bool[] seats)
        {
            Random random = new Random();
            for (int i = 0; i < seats.Length; i++)
            {
                int availability = random.Next(0, 2);
                if (availability == 1)
                {
                    seats[i] = true;
                }
                else
                {
                    seats[i] = false;
                }
            }
        }
        void DisplaySeatingArrengement(bool[] seats)
        {
            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == true)
                {
                    Console.WriteLine((i + 1) + ": Available");
                }
                else
                {
                    Console.WriteLine((i + 1) + ": Booked");
                }
            }
        }
        void BookSeat(bool[] seats, int seatNumber)
        {
            while (true)
            {
                if (seats[seatNumber - 1] == true)
                {
                    seats[seatNumber - 1] = false;
                    Console.WriteLine($"Seat {seatNumber} has been succecfully booked.");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine($"Seat {seatNumber} is already booked. Please select another seat.");
                    seatNumber = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
