using System;
using System.Threading;

namespace _07_ThreadMetodos
{
    class Program
    {
        //Thread Sleep
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio do Nosso Programa");
            Thread.Sleep(3000);
            Console.WriteLine("Termino do Nosso Programa");
            Console.ReadKey();

            //Thread Join

            Thread t1 = new Thread(ThreadRepition);
            Thread t2 = new Thread(ThreadRepition);
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();

            Console.WriteLine("Termino do Nosso Programa");
            Console.WriteLine("Termino do Nosso Programa");
            Console.WriteLine("Termino do Nosso Programa");
            Console.WriteLine("Termino do Nosso Programa");


        }
        static void ThreadRepition(object Id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread " + Id + " - Num - " + i + " ID Interno - " + Thread.CurrentThread.ManagedThreadId);

            }



        }
    }
}

