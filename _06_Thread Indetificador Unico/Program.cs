using System;
using System.Threading;

namespace _02_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepition);
                t1.Start(i);
            }
           
            Console.ReadKey();
        }
        //IO - Tela(Monitor),Rede e Armazenamento.
        static void ThreadRepition(object Id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread " + Id + " - Num - " +i +" ID Interno - " + Thread.CurrentThread.ManagedThreadId);

            }
        }
    }
}
