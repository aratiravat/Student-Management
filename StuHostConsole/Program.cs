using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StuHostConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:8080/StudentService");
            using (ServiceHost serviceHost = new ServiceHost(typeof(Student.Service1), uri))
            {
                try
                {
                    // Open the service host
                    serviceHost.Open();
                    Console.WriteLine("The service is ready.");
                    Console.WriteLine("Press any key to close the service.");
                    Console.ReadKey();
                    // Close the service host
                    serviceHost.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    // Close the service host if it was not null
                    serviceHost?.Abort();
                }
            }
        }
    }
}
