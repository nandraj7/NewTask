

public class Factors
{
    public static void Main()
    {
        Console.WriteLine("Enter Any Number :");
        int Number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fectors Number of =" + " " + Number);
        for (int i = 1; i <= Number; i++)
        {
            if (Number % i == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadLine();


    }
}