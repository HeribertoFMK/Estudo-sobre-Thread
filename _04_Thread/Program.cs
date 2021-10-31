using System;
using System.Threading;

namespace _02_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DataIni" +DateTime.Now);
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepition);
                t1.IsBackground = true;
                t1.Start();
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
            Console.WriteLine("DataIni" + DateTime.Now);
        }
    }
}
