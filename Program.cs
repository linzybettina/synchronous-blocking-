using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading;

namespace CSharpThreadExample
{
    class Program
    {
        public static void run()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("In thread " + Thread.CurrentThread.Name + i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Starting");
            Thread.CurrentThread.Name = "Main ";

            Thread t1 = new Thread(new ThreadStart(run));
            t1.Name = "Child";
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("In thread " + Thread.CurrentThread.Name + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Main Thread Terminates");
            Console.Read();
        }
    }
}