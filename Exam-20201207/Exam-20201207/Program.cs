using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_20201207
{
    internal class Program
    {
        public void FirstStar(int row)
        {
            List<string> star = new List<string>();
            string item = string.Empty;
            for (int i = 1; i < 100; i++)
            {
                item += "*";
                if (i % 2 != 0)
                {
                    star.Add(item);
                    if (star.Count == row)
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < star.Count; i++)
            {
                Console.WriteLine(star[i].PadLeft(row + i, ' '));
            }
            Console.ReadLine();
        }

        public void SecondStar(int row)
        {
            List<string> starlist = new List<string>();
            string itemstar = string.Empty;
            for (int i = 1; i < 100; i++)
            {
                itemstar += "*";
                if (i % 2 != 0)
                {
                    starlist.Insert(0, itemstar);
                    if (starlist.Count == row)
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine(starlist[i].PadLeft(row * 2 - 1 - i, ' '));
            }
            Console.ReadLine();
        }

        public void ThirdStar(int row)
        {
            List<string> star = new List<string>();
            string item = string.Empty;
            for (int i = 1; i < 100; i++)
            {
                item += "*";
                if (i % 2 != 0)
                {
                    star.Add(item);
                    if (star.Count == row)
                    {
                        break;
                    }
                }
            }

            for (int i = 1; i < 3; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine(star[j].PadLeft(row + j, ' '));
                    }
                    else
                    {
                        if (j == 0)
                        {
                            j += 1;
                        }
                        List<string> ans = star.OrderByDescending(x => x.Length).ToList();
                        Console.WriteLine(ans[j].PadLeft(row * 2 - 1 - j, ' '));
                    }
                }
            }
            Console.ReadLine();
        }

        private static void Main(string[] args)
        {
            Program program = new Program();
            program.FirstStar(3);
            program.SecondStar(3);
            program.ThirdStar(3);
        }
    }
}