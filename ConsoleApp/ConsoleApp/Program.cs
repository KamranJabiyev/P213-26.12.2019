using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Loop1);
            Thread thread2 = new Thread(Loop2);
            
            thread1.Start();
            thread1.Join();
            thread2.Start();
            Loop3();
            //Loop4();
            //Loop1();
            //Loop2();
        }

        static void Loop1()
        {
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine($"Loop1: {i}");
            }
        }

        static void Loop2()
        {
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine($"Loop2: {i}");
            }
        }

        static void Loop3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Loop3: {i}");
            }
        }

        static void Loop4()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Loop4: {i}");
            }
        }
    }
}
