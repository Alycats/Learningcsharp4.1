namespace Learningcsharp4._1;
class Program
{
    static void Main(string[] args)
    {

        int[] heightInCM = new int[5];
        double[] heightInInches = new double[5];


        for (int i = 0; i < 5; i++)
        {
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Enter a Height in CM");
                    heightInCM[i] = Convert.ToInt32(Console.ReadLine());
                    validInput = true;
                }
                catch ("Invalid input, try again")
                {
                    Console.WriteLine(e);
                }
            }
        }

        for (int i = 0; i < 5; i++)
        {
            heightInInches[i] = heightInCM[i] / 2.54;
        }
        Console.Write("Heights: ");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($" {heightInCM[i]} CM = {heightInInches[i]: 0.##} inches, ");

        }



        Console.WriteLine("Hello, World!");
        Console.ReadKey(true);



    }
}
