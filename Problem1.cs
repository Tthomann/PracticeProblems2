using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems2
{
    public class InputCheck
    {
        List<string> CollectiveInput = new List<string>();
        string userInput;
        public InputCheck()
        {

        }
        public string UserInput()
        {
            
            return userInput;
        }
        public void CheckList()
        {
            
            CollectiveInput.Add(" ");

            for (int checker = 0; checker < CollectiveInput.Count; checker++)
            {
                Console.WriteLine("enter a word");
                userInput = Console.ReadLine();

                if(CollectiveInput[checker] == userInput)
                {
                    Console.WriteLine("BARK, THATS ALREADY BEEN ENTERED BARK");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("youuuuu did it!");
                    CollectiveInput.Add(userInput);
                    
                    
                }
            }
        
        }

    }
}
