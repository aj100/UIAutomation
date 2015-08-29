using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using TestStack.White;
using TestStack.White.InputDevices;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace UIAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            var processToRun = new ProcessStartInfo(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "--profile-directory=Default --app-id=ipgcjcifbaemgjdhhnfadphdncjabbna");
            var app = Application.Launch(processToRun);

            Thread.Sleep(2500);

            Mouse.Instance.Location = new Point(220, 560);
            
            int count = 25;
            for(int i=0; i<count; i++)
            //while(true)
            {
                Mouse.Instance.Click();
            }

            app.Close();
        }
    }
}
