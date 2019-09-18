using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace LambdaTest
{
    public class Program
    {
        private static int i = 0;
        //static void Main(string[] args)
        //{
        //    Thread td = new Thread(new ThreadStart(Test));
        //    td.IsBackground = true;
        //    td.Start();
        //    for (; i < 100; ++i)
        //    {
        //        Console.WriteLine("主线程：" + i);
        //    }
        //    Console.ReadKey();
        //}

        #region task

        public static void Test()
        {
            for (; i < 100; ++i)
            {
                Console.WriteLine("副线程：" + i);
            }
        }
        
        #endregion

    }
}
