﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_26
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteMultipleRequestsInParallel();
            ExecuteMultipleRequests();
        }

        public static async Task ExecuteMultipleRequestsInParallel()
        {
            HttpClient client = new HttpClient();

            Task microsoft = client.GetStringAsync("http://www.microsoft.com");
            Task msdn = client.GetStringAsync("http://www.microsoft.com");
            Task blogs = client.GetStringAsync("http://blog.msdn.com/");

            await Task.WhenAll(microsoft, msdn, blogs);
        }

        public static async Task ExecuteMultipleRequests()
        {
            HttpClient client = new HttpClient();

            string microsoft =await client.GetStringAsync("http://www.microsoft.com");
            string msdn = await client.GetStringAsync("http://www.microsoft.com");
            string blogs = await client.GetStringAsync("http://blog.msdn.com/");
        }
    }
}
