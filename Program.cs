using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Problem2 problem2 = new Problem2();
            problem2.MakeTriangle();

            problem2.DownTriangle();
           problem2.flipTriangle();
            Console.ReadLine();

            bool TylerisCool = true;
            Problem1 inputCheck = new Problem1();

            while(TylerisCool)
             {
            inputCheck.CheckList();
             }
        }
    }
}
