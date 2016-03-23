using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems2
{
    class Problem2
    {
        List<List<string>> Triangle = new List<List<string>>();
        List<List<string>> UpsideDownTriangle = new List<List<string>>();
        List<List<string>> FlipTriangle = new List<List<string>>();
        int outerIndex;
        int innerIndex;
        int sizeOfList =5;
        int mainList;
       
        public Problem2()
        {
        }
        public void MakeTriangle()
        {
            for (outerIndex = 0; outerIndex < sizeOfList; outerIndex++)
            {
                Triangle.Add(new List<string>());

                for (innerIndex = 0; innerIndex < outerIndex + 1; innerIndex++)
                {

                    Console.Write("*");
                    if (outerIndex == innerIndex)
                    {
                        Console.WriteLine("\n");
                    }
                }
                
            }
            Console.ReadLine();
        }
          
           
        public void DownTriangle()
        {
            for (outerIndex = 0; outerIndex < sizeOfList; outerIndex++)
            {
                UpsideDownTriangle.Add(new List<string>());

                for (innerIndex = sizeOfList - outerIndex; innerIndex > 0; innerIndex--)
                {
                    Triangle[outerIndex].Add("*");
                    Console.Write("*");
                 }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
        public void flipTriangle()
        {
        for(mainList =1; mainList <= sizeOfList; mainList++)
            {
                for(outerIndex=1; outerIndex <= sizeOfList- mainList; outerIndex++)
                {
                    Console.Write(" ");
                }
                for(innerIndex = 1; innerIndex <= mainList; innerIndex++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }

    }
   
    }


