using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using log4net;

namespace Lab4
{

    class Program
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            ImplementLoggingFuntion();
        }

        private static void ImplementLoggingFuntion()
        {
            String userId="300", password="300";
            int count = 0;
            Console.WriteLine("Enter userId: ");
            Console.WriteLine("Enter password: ");

            while (count < 3)
            {
                string Id = Console.ReadLine();
                string pw = Console.ReadLine();
                if(!Id.Equals(userId) || !pw.Equals(password))
                {
                    Console.WriteLine("you are fucking wrong, "+(2-count)+" tries remained");
                    count++;
                }
                else
                    break;
                   
            }
            if (count < 3)
                Console.WriteLine("you are now looged in, hello " + userId);
            else
                Console.WriteLine("fuck off you fucking hacker");
            
            /* We have 5 levels of log message. Let's test all.
             *  FATAL
                ERROR
                WARN
                INFO
                DEBUG
             */
            var secs = 3;
            Log.Fatal("Start log FATAL...");
            Console.WriteLine("Start log FATAL...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Error("Start log ERROR...");
            Console.WriteLine("Start log ERROR...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Warn("Start log WARN...");
            Console.WriteLine("Start log WARN...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Info("Start log INFO...");
            Console.WriteLine("Start log INFO...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Debug("Start log DEBUG...");
            Console.WriteLine("Start log DEBUG...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        }
    }
}
