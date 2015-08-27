using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace UIAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use the arc welder extension
            //Use this place to get the APK: http://www.apkmirror.com/
            //Use this advice to make it a separate app: http://www.howtogeek.com/214734/how-to-use-googles-arc-welder-to-run-android-apps-in-chrome/
            //In Chrome go to the app, right click and "Create Shortcut", right click on the desktop icon and get the command line properties from there


            var processToRun = new ProcessStartInfo(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "--profile-directory=Default --app-id=gghggeiabpiljhchlhoamhhdicnpalci");
            var app = Application.Launch(processToRun);
            var window = app.GetWindows().Single();
            
            var x = window.GetMultiple(SearchCriteria.All);

            window.Close();
        }
    }
}
