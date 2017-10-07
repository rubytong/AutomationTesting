//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.IE;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Support.UI;
//using log4net.Appender;

//namespace z.JenkinsRunning
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestMethod1()
//        {
//            //Logger.Info("abc");
//            //Logger.Error("cdf");

//            ConsoleAppender appender = new ConsoleAppender();
//            using (IWebDriver driver = new ChromeDriver())
//            {
//                driver.Navigate().GoToUrl("http://www.google.com/");
//                IWebElement searchTextbox = driver.FindElement(By.Name("q"));
//                searchTextbox.SendKeys("ruby");
//                searchTextbox.Submit();


//                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//                wait.Until(d => d.Title.StartsWith("ruby", StringComparison.InvariantCultureIgnoreCase));

//                Console.WriteLine("Page title is: " + driver.Title);


//            }
//        }
//    }
//}

using System;
using System.Threading;

public class Worker
{
    // This method is called when the thread is started.
    public void DoWork()
    {
        while (!_shouldStop)
        {
            Console.WriteLine("Worker thread: working...");
        }
        Console.WriteLine("Worker thread: terminating gracefully.");
    }
    public void RequestStop()
    {
        _shouldStop = true;
    }
    // Keyword volatile is used as a hint to the compiler that this data
    // member is accessed by multiple threads.
    private volatile bool _shouldStop;
}

public class WorkerThreadExample
{
    static void Main()
    {
        // Create the worker thread object. This does not start the thread.
        Worker workerObject = new Worker();
        Thread workerThread = new Thread(workerObject.DoWork);

        // Start the worker thread.
        workerThread.Start();
        Console.WriteLine("Main thread: starting worker thread...");

        // Loop until the worker thread activates.
        while (!workerThread.IsAlive) ;

        // Put the main thread to sleep for 1 millisecond to
        // allow the worker thread to do some work.
        Thread.Sleep(1);

        // Request that the worker thread stop itself.
        workerObject.RequestStop();

        // Use the Thread.Join method to block the current thread 
        // until the object's thread terminates.
        workerThread.Join();
        Console.WriteLine("Main thread: worker thread has terminated.");
    }
    // Sample output:
    // Main thread: starting worker thread...
    // Worker thread: working...
    // Worker thread: working...
    // Worker thread: working...
    // Worker thread: working...
    // Worker thread: working...
    // Worker thread: working...
    // Worker thread: terminating gracefully.
    // Main thread: worker thread has terminated.
}