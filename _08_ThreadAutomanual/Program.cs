using System;
using System.Threading;
namespace _08_ThreadAutomanual
{
    class Program
    {
        static ManualResetEvent Manual01;
        static AutoResetEvent Auto01;
        static void Main(string[] args)
        {
            Manual01 = new ManualResetEvent(false);
            Auto01 = new AutoResetEvent(false);
            Thread t1 = new Thread(Exececuta01);
            t1.Start();

            Thread t2 = new Thread(Exececuta02);
            t2.Start();

            Thread.Sleep(5000);
            Manual01.Set();
            Manual01.Reset();

            Auto01.Set();

            Thread.Sleep(5000);
            Manual01.Set();
            Auto01.Set();


            Console.ReadKey();
            
        }
        static void Exececuta01()
        {
            Console.WriteLine("01 - Iniciado Executa01");
            Manual01.WaitOne();
            Console.WriteLine("02 - Execução Executa01");
            Console.WriteLine("03 - Execução Executa01");
            Manual01.WaitOne();
            Console.WriteLine("04 - Finalizado Executa01");
        }
        static void Exececuta02()
        {
            Console.WriteLine("01 - Iniciado Executa02");
            Console.WriteLine("02 - Execução Executa02");
            Auto01.WaitOne();
            Console.WriteLine("03 - Execução Executa02");
            Auto01.WaitOne();
            Console.WriteLine("04 - Finalizado Executa02");

        }
    }
}
    

    
        

