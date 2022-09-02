// 2.	Program, który wypisze wszystkie liczby od 1 do 100, które są podzielne przez 3

namespace IP_Task1_100Div3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
 
            }

            Console.ReadLine();
        }
    }
}