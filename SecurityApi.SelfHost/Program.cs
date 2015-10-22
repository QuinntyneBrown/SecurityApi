using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace SecurityApi.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9002/";

            WebApp.Start<SecurityApi.SelfHost.StartUp>(url: baseAddress);

            Console.ReadLine();
        }
    }
}
