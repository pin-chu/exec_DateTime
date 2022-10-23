using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec_DateTime
{
	class Program
	{
		static void Main(string[] args)
        {//Q1 計算三天後DVD歸還的時間

            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(3);

            Console.WriteLine(end);

            //Q2計算圖書下個月歸還的時間

            DateTime today = DateTime.Today;
            var dt1 = today.AddMonths(1);

            Console.WriteLine(dt1);

            //Q3取得本月一日

            DateTime firstday = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            Console.WriteLine(firstday);

            //Q4取得本月最後一天

            DateTime lastday = new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 1).AddDays(-1);

            Console.WriteLine(lastday);


            //Q5列出指定年份的每一個星期日

            var start2 = new DateTime(DateTime.UtcNow.Year, 1, 1);
            var end2 = start2.AddYears(1);

            while (start2 < end2)
            {
                if (start2.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine(start2);
                    start2 = start2.AddDays(7);
                }
                else
                    start2 = start2.AddDays(1);
            }
            //Q6根據日期，傳回今天是本月上旬中旬或下旬

            int start3 = Convert.ToInt32(DateTime.Now.ToString("dd"));

            if (start3 <=10)
            {
               Console.WriteLine ("上旬");
            }
            else if (start3 > 10 && start3 <= 20)
            {
                Console.WriteLine("中旬");
            }
            else
            {
                Console.WriteLine("下旬");
            }
            

            //Q7根據不同時間，傳回不同問安方式
            int start4 = Convert.ToInt32(DateTime.Now.ToString("HH"));

            if (start4 <= 12)
            {
                Console.WriteLine("早安");
            }
            else if (start4 >= 12 && start4 <= 18)
            {
                Console.WriteLine("午安");
            }
            else
            {
                Console.WriteLine("晚安");
            }
        }
	}
}
