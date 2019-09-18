using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LambdaTest
{
    class TaskTest
    {
        static void Main()
        {
            Console.WriteLine("执行前：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ", Id：" + Thread.CurrentThread.ManagedThreadId);
            Task<bool> v = Task.Run<bool>(() =>
            {
                return GetResult();
            });
            if (v.Result == true)
            {
                Console.WriteLine(v.Result); //将会阻塞，直到GetResult执行完
            }
            Console.WriteLine("执行后：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ", Id：" + Thread.CurrentThread.ManagedThreadId);
            Console.ReadKey();
        }

        private static bool GetResult()
        {
            Thread.Sleep(2000);
            Console.WriteLine("返回值, Id：" + Thread.CurrentThread.ManagedThreadId);
            return true;
        }
    }
}
