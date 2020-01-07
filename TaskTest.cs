using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUpload
{
    /// <summary>
    /// Task测试
    /// </summary>
    class TaskTest
    {
        /// <summary>
        /// 多线程测试
        /// </summary>
        public void download1()
        {
            var loop = 0;
            var task1 = new Task<int>(() =>
            {
                for (var i = 0; i < 1000; i++)
                {
                    loop += i;
                    Console.WriteLine("Task1");
                }
                    
                return loop;
            });
            task1.Start();
            var loopResut = task1.Result;

            var task2 = new Task<long>(obj =>
            {
                long res = 0;
                var looptimes = (int)obj;
                for (var i = 0; i < 1000; i++)
                {
                    res += i;
                    Console.WriteLine("Task2");
                }
                   
                return res;
            }, loopResut);

            task2.Start();
            var resultTask2 = task2.Result;

            Console.WriteLine("任务1的结果':{0}\n任务2的结果:{1}", loopResut, resultTask2);
        }
    }
}
