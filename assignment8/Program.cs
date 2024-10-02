namespace assignment8
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
            string[] albums = new string[100];
            int count = 0;
            do
            {
                string input = Console.ReadLine();
                if (input == "yes")
                {
                    string newAlbum = Console.ReadLine();
                    albums[count] = newAlbum;
                    count++;
                }
                else if (input == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    break;
                }


            } while (true);
            DisplayAlbums(albums, count);
        }
        void DisplayAlbums(string[] albums, int numberOfAlbums)
        {
            for (int i = 0; i < numberOfAlbums; i++)
            {
                Console.WriteLine(albums[i]);
            }

        }
        bool FindAlbum(string[] albums, int numberOfAlbums, string searchAlbum)
        {
            return false;
        }
    }
}
