using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cap._1_List1_19
{
    public static class Program
    {
        /*Scalability versus responsiveness
         * */
        public static void Main(string[] args)
        {
        }

        public Task SleepAsyncA(int millisecondsTimeout)
        {
            return Task.Run(() => Thread.Sleep(millisecondsTimeout));
        }

        public Task SleepAsyncB(int millisencondsTimeout)
        {
            //use scalability
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); },
                null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisencondsTimeout, -1);

            return tcs.Task;
        }
    }
}
