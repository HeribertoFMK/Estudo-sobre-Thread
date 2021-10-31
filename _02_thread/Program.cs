using System;
using System.Threading;

namespace _02_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadRepition);
            t1.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main" + i);
            }
            Console.ReadKey();
        }
        //IO - Tela(Monitor),Rede e Armazenamento.
        static void ThreadRepition()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("num " + i);

            }
        }
    }
}
