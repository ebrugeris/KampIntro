namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i>= 0; i--)
            {
                if (i%2==0)
                {
                    Console.WriteLine("çift sayı = "+ i);
                }
                else if (i%2==1) 
                {
                    Console.WriteLine("tek sayı = "+ i);
                }
                else {
                    Console.WriteLine("sayı =" +i);
                }
            }

        }
    }
}