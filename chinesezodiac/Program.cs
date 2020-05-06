using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinesezodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] yearName = { "원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양" };

            Console.Write("태어난 년도를 입력하세요... : ");
            int year = int.Parse(Console.ReadLine());

            switch (year % 12)
            {
                case 0:
                    Console.WriteLine(yearName[year % 12]+"띠 입니다!");
                    break;
                case 1:
                    Console.WriteLine(yearName[year % 12] + "띠 입니다!");
                    break;
                case 2:
                    Console.WriteLine(yearName[year % 12] + "띠 입니다!");
                    break;
                case 3:
                    Console.WriteLine(yearName[year % 12] + "띠 입니다!");
                    break;
                case 4:
                    Console.WriteLine(yearName[year % 12] + "띠 입니다!");
                    break;
                case 5:
                    Console.WriteLine(yearName[year % 12] + "띠 입니다!");
                    break;
                case 6:
                    Console.WriteLine(yearName[year % 12] + "띠 입니다!");
                    break;
                case 7:
                    Console.WriteLine(yearName[year % 12] + "띠 입니다!");
                    break;
                case 8:
                    Console.WriteLine(yearName[year % 12] + "띠 입니다!");
                    break;
                case 9:
                    Console.WriteLine(yearName[year % 12] + "띠 입니다!");
                    break;
                case 10:
                    Console.WriteLine(yearName[year % 12] + "띠 입니다!");
                    break;
                case 11:
                    Console.WriteLine(yearName[year % 12] + "띠 입니다!");
                    break;
                case 12:
                    Console.WriteLine(yearName[year % 12] + "띠 입니다!");
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다.");
                    break;
            }
        }
    }
}
