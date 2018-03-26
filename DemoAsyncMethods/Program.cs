using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAsyncMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumN(new Vector(1, 100)));
            List<Task<int>> SumTaskList = new List<Task<int>>();
            int n = 100;
            int taskNum = 4;
            int length = n / taskNum;
            for(int i = 1; i < n; i += length)
            {
                Task<int> sumTask = Task<int>.Factory.StartNew(SumN, new Vector(i, length));
                SumTaskList.Add(sumTask);
            }

            Task.WaitAll(SumTaskList.ToArray());

            int result = 0;
            for(int i = 0; i < taskNum; i++)
            {
                result += SumTaskList[i].Result;
            }

            Console.WriteLine("Sum: "+result);

            Console.Read();
        }

        public static int SumN(object vec)
        {
            Vector v = (Vector)vec;
            int result = 0;
            for (int i = v.Start; i <= v.End; i++) {
                result += i;

            }
            return result;
        }

        public static bool IsPrime(object n)
        {
            int num = (int)n;
            if (num < 2)
                return false;
            for(int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i==0)
                    return false;
            }
            return true;
        }


    }
}
