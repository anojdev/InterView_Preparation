
using Interview_C_Sharp.Events.FileDownloadExample;

var fileDownloader = new FileDownloader();

//subscribe to the events

fileDownloader.DownloadStarted += (sender, e) =>
{
    Console.WriteLine("Download Started....");
};

fileDownloader.DownloadProgress += (sender, per) =>
{
    Console.WriteLine($"Download progress: {per}%");
};

fileDownloader.DownloadCompleted += (sender, e) =>
{
    Console.WriteLine("Download completed !");
};

//start download asynchrnously

await fileDownloader.DownloadFileAsync();