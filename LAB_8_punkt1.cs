using System;
using System.Threading;

namespace Lab_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread thread1 = new Thread(() =>
            {
                for (int i = 1; i <= 5; ++i)
                {
                    Console.WriteLine("Iteration1: " + i);
                    Thread.Sleep(1000); // Zatrzymuje się na 1s,
                                        // treść wyświetla się stopniowo
                }
            });
            Thread thread2 = new Thread(() =>
            {
                for (int i = 1; i <= 5; ++i)
                {
                    Console.WriteLine("Iteration2: " + i);
                    Thread.Sleep(1000);
                }
            });
            thread1.Start();
            thread2.Start();

            Thread.Sleep(1000);  // Główny wątek jest opóżniony o 1 sekundę
            //Oba wątki wywołują się w tym samym czasie.

        }
    }
}