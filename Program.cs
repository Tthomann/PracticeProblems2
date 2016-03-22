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
            bool TylerisCool = true;
            InputCheck inputCheck = new InputCheck();
            
            while(TylerisCool)
            {
                //inputCheck.UserInput();
                inputCheck.CheckList();
            }
        }
    }
}
