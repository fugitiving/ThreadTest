using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaTest
{
    class MultiThread
    {
        public delegate string MyThread(string name);
        //static void Main()
        //{
        //    MyThread mt = new MyThread(GetName);
        //    string name = "my";
        //    IAsyncResult result = mt.BeginInvoke(name, null, null);
        //    Console.WriteLine(mt.EndInvoke(result));
        //    Console.ReadKey();
        //}

        public static string GetName(string name)
        {
            return name + " test";
        }
    }
}
