using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_C_Sharp.Events.FileDownloadExample
{
    //Declare a delegate for each event
    public delegate void DownloadStartedEventHandler(object sender, EventArgs e);
    public delegate void DownloadProgressEventHandler(object sender, int percentage);
    public delegate void DownloadCompletedEventHandler(object sender, EventArgs e);
    internal class FileDownloader
    {
        //Step-3: Declare the events using the delegates
        public event DownloadStartedEventHandler DownloadStarted;
        public event DownloadProgressEventHandler DownloadProgress;
        public event DownloadCompletedEventHandler DownloadCompleted;

        //Method to start downloading the file
        public async Task DownloadFileAsync()
        {
            //Step-4: Raise the DownloadStarted event
            OnDownloadStarted();

            for(int i = 0; i < 100; i++)
            {
                //Simulate downloading process
                await Task.Delay(500);
                OnDownloadProgress(i);
            }

            //
            OnDownloadCompleted();
        }

        protected void OnDownloadStarted()
        {
            DownloadStarted?.Invoke(this, EventArgs.Empty);
        }

        protected void OnDownloadProgress(int percentage)
        {
            DownloadProgress?.Invoke(this, percentage);
        }

        protected void OnDownloadCompleted()
        {
            DownloadCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
