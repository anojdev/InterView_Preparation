

using Delegate;
using Delegate.LogHandlers;

var logger = new Logger();

//Attach differentlog handlers (Subscribers)
logger.LogeMessage += new ConsoleLogger().HandleLog;
logger.LogeMessage += new FileLogger().HandleLog;


logger.Log("This is a log message.");

Console.WriteLine("Testing....");

Console.ReadKey();