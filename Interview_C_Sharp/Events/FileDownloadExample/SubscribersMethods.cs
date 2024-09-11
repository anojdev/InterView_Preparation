using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_C_Sharp.Events.FileDownloadExample
{
    internal class SubscribersMethods
    {
        // Event handler for DownloadStarted
        public static void OnDownloadStarted(object sender, EventArgs e)
        {
            Console.WriteLine("Download started...");
        }
    }
}
