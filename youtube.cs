using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems2
{
    class youtube
    {
        public youtube()
        {
            
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.youtube.com/watch?v=UJDhBU-LneM");
        }
        ~youtube()
        {
            GC.Collect();
        }
        public void goYoutube()
        {
            Process goYoutube = new Process();
            GC.Collect(youtube);
        }
    }
}
