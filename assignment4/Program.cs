namespace assignment4
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
            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();
            Console.Write("Enter number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            string[] names = new string[numberOfStudents];
            int[] grades = new int[numberOfStudents];
            ReadNames(names);
            ReadGrades(grades);
            Console.WriteLine("Student " + GetHighestGradeIndex(grades));

        }
        void ReadNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name of student {i}: ");
                names[i] = Console.ReadLine();
            }

        }
        void ReadGrades(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Enter grade of student {i}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }

        }
        int GetHighestGradeIndex(int[] grades)
        {
            int highestGrade = grades[0];
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > highestGrade)
                {
                    highestGrade = grades[i];
                }
            }
            return highestGrade;
        }
    }
}
