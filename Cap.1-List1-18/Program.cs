using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_18
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string result = DownloadContent().Result;
        }

        public static async Task<string> DownloadContent()
        {
            using(HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
            
        }
    }
}
