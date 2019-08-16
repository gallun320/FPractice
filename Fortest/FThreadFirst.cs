using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Fortest
{
    public class FThreadFirst
    {
        static bool _done = false;
        static object _locker = new object();
        static Mutex mtx = new Mutex();
        static EventWaitHandle wh = new AutoResetEvent(false);
        public FThreadFirst()
        {

        }

        public void GoThread()
        {
            var thread = new Thread(FThreadFirst.Go);
            thread.Start();
            FThreadFirst.Go();
        }

        public void TexterThread()
        {
            new Thread(Texter).Start();
            Thread.Sleep(1000);
            wh.Set();
        }

        public static void Go()
        {
            lock(_locker)
            {
                if (!_done)
                {
                    Console.WriteLine("Done");
                    _done = true;
                }
            }
        }

        public static void GoWithMutex()
        {
            mtx.WaitOne();
            if (!_done)
            {
                Console.WriteLine("Done");
                _done = true;
            }
            mtx.ReleaseMutex();
        }


        static bool IsValidWalkThread(string[] walk)
        {
            var n = new Dictionary<string, int>();

            foreach (var letter in walk)
            {
                if (n.TryGetValue(letter, out var num))
                {

                    n[letter] = ++num;
                }
                else
                {
                    n[letter] = 1;
                }
            }

            var i = n.Values.Max();
            var j = n.Values.Min();
            if (walk.Length == 10 && j == i) return true;
            return false;
        }

        static void Texter()
        {
            Console.WriteLine("Signal...");
            wh.WaitOne();
            Console.WriteLine("I got it...");
        }
    }
}
