using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            //將號碼放入List之中
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 42; i++)
            {
                numbers.Add(i);
            }

            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                //隨機挑選印出
                int r = rand.Next(1, numbers.Count);
                Console.WriteLine(numbers[r] + "");

                //從List中刪除
                numbers.RemoveAt(r);

                //重複2~3六次
            }
            //停止
            Console.ReadKey();
        }
    }
}
