internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        int[] marks = new int[5];
        for (int y = 0; y < marks.Length; y++)
        {
            Console.WriteLine("Enter the marks");
            marks[y] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("************************************************");
        Console.WriteLine("Mark\t\t\t\t\t\tLevel");

        for (int y = 0; y < marks.Length; y++)
        {
            Console.Write(marks[y] + " ");
            switch (marks[y])
            {
                case 90: case 91: case 92: case 93: case 94: case 95: case 96: case 97: case 98: case 99: case 100:
                
                    Console.WriteLine("\t\t\t\t\t\t9");
                    break;

                case 80: case 81: case 82: case 83: case 84: case 85: case 86: case 87: case 88: case 89:
                    Console.WriteLine("\t\t\t\t\t\t8");
                    break;


                // ... (repeat for other cases)
                default:
                    Console.WriteLine("\t\t\t\t\tInvalid level");
                    break;
            }
        }

        Console.WriteLine(".................................................");
        int total = 0;

        for (int t = 0; t < marks.Length; t++)
        {
            total = total + marks[t];
        }

        Console.WriteLine("The total of the marks is: " + total);
        Console.WriteLine("..................................................");

        double average = (double)total / marks.Length;
        Console.WriteLine("The average of the student's marks is: " + average);
        Console.WriteLine("***************************************************");

        int min = marks[0];
        int max = marks[0];

        for (int g = 0; g < marks.Length; g++)
        {
            if (marks[g] < min)
            {
                min = marks[g];
            }

            if (marks[g] > max)
            {
                max = marks[g];
            }
        }

        Console.WriteLine("The minimum mark is, " + min);
        Console.WriteLine("The maximum mark is, " + max);
    }
}


    
