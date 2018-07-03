using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingAsyncAwait
{
    class Program
    {
        static async Task<int> HandleFileAsync()
        {
            string file = @"C:\poop\enable.txt";
            Console.WriteLine("HandleFile enter");
            int count = 0;
            // Read in the specified file.
            // ... Use async StreamReader method.
            using (StreamReader reader = new StreamReader(file))
            {
                string v = await reader.ReadToEndAsync();
                // ... Process the filed at a somehow.
                count += v.Length;
                // ... A slow-running computation.
                //     Dummy code.
                for (int i = 0; i < 1000; i++)
                {
                    int x = v.GetHashCode();
                    if (x == 0)
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine("HandleFile exit");
            return count;

        }
        static void Main(string[] args)
        {
            // Start the HandleFile method.
            Task<int> task = HandleFileAsync();
            // Control returns here before HandleFileAsync returns.
            // ... Prompt the user.
            Console.WriteLine("Please wait patiently " +
                "while I do something important.");

            // Do something at the same time as the file is being read.
            string line = Console.ReadLine();
            Console.WriteLine("You entered (asynchronous logic): " + line);
            // Wait for the HandleFile task to complete.
            // ... Display its results.
            task.Wait();
            var x = task.Result;
            Console.WriteLine("Count: " + x);
            Console.WriteLine("[DONE]");
            Console.ReadLine();
        }
    }
}
