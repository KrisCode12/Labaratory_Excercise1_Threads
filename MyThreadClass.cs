using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmBasicThread1
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i<=5; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: {0} = {1}", thread.Name, i);

                if (i == 5)
                {

                }
            } 
        }

    }
}
