using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Fortest
{
    class FOop
    {
    }

    public abstract class Operation
    {
        public double Result;
        public abstract void Execute(double variable1, double variable2);
    }

    public class Multiply : Operation
    {
        public override void Execute(double f, double s)
        {
            Result = f * s;
        }
    }

    public class Add : Operation
    {
        public override void Execute(double f, double s)
        {
            Result = f + s;
        }
    }

    public class Subtract : Operation
    {
        public override void Execute(double f, double s)
        {
            Result = f - s;
        }
    }

    public class Divide : Operation
    {
        public override void Execute(double f, double s)
        {
            Result = f - s;
        }
    }

    public class Rebrend
    {
        public enum Status
        {
            Default = 0,
            New = 1,
            Active = 2,
            Deactivated = 3
        }

        private readonly Status _status;
        private readonly Dictionary<Status, string> _statusDescriptions = new Dictionary<Status, string>()
      {
       {Status.Default, "I have never been set" },
       {Status.New, "I am new!" },
       {Status.Active, "I am active" },
       {Status.Deactivated, "I have been deactivated" }
      };

      public Rebrend()
        {
        }

        public Rebrend(Status status)
        {
            _status = status;
        }

        public string GetStatusDescription()
        {
            try
            {
                return _statusDescriptions[_status];
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException("Invalid status encountered");
            }
        }
    }


    public partial class Nodes
    {
        public int Data;
        public Nodes Next;

        public Nodes(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public static int Length(Nodes head)
        {
            var count = 0;
            var node = head;
            while(node != null)
            {
                ++count;
                node = node.Next;
            }
            return count;
        }

        public static int Count(Nodes head, Predicate<int> func)
        {
            var count = 0;
            var node = head;
            while (node != null)
            {
                if(func(node.Data)) ++count;
                node = node.Next;
            }
            return count;
        }
    }

    public class ThreadTest
    {
        static bool done;
        static object locker = new object();

        public static void Go()
        {
            lock(locker)
            {
                if (!done)
                {
                    Console.WriteLine("Done");
                    done = true;
                }
            }
        }

        public static void DelegateTest()
        {
            var bf = "before";
            var t1 = new Thread(delegate () { WriteText(bf); });
            bf = "After";
            t1.Start();
        }

        public static void WriteText(string str)
        {
            Console.WriteLine(str);
        }
    }

    public class Plugboard
    {
        private readonly char[] _alphabet;
        public Plugboard(String wires = "")
        {
            if (wires.Length > 20) throw new Exception();
            if (wires.Length % 2 != 0) throw new Exception();
            if (wires.Distinct().ToArray().Length < wires.Length) throw new Exception();
            _alphabet = wires.ToCharArray();
        }
        public char process(char c)
        {
            if (Array.IndexOf(_alphabet, c) == -1) return c;
            var idx = Array.IndexOf(_alphabet, c);
            return idx % 2 == 0 ? _alphabet[idx + 1] : _alphabet[idx - 1];
        }
    }

    public static class NumberExtension
    {
        public static object FeetToCentimeters(this object n)
        {
            return (object)(Convert.ToDouble(n) * 30.48);
        }

        public static object CentimetersToFeet(this object n)
        {
            return n;
        }
    }

    class MYRainfall
    {
        public static double Mean(string town, string strng)
        {
            if (town == "") return -1;
            if (strng.IndexOf(town, 0) == -1) return -1;
            var start = strng.IndexOf(town, 0) + town.Length + 1;
            var end = strng.IndexOf("\n", start);
            double result = 0.0d;
            try
            {
                result = Regex.Replace(strng.Substring(start, end == -1 ? strng.Length - start : end - start), "[a-z,]", "", RegexOptions.IgnoreCase).Replace(".", ",").Trim().Split(' ').Select(x => Convert.ToDouble(x)).Average();
            }
            catch
            {
                return -1;
            }
            return result;
        }

        public static double Variance(string town, string strng)
        {
            if (town == "") return -1;
            if (strng.IndexOf(town, 0) == -1) return -1;
            var start = strng.IndexOf(town, 0) + town.Length + 1;
            var end = strng.IndexOf("\n", start);
            List<double> collection = null;
            try
            {
                collection = Regex.Replace(strng.Substring(start, end == -1 ? strng.Length - start : end - start), "[a-z,]", "", RegexOptions.IgnoreCase).Replace(".", ",").Trim().Split(' ').Select(x => Convert.ToDouble(x)).ToList();
            }
            catch
            {
                return -1;
            }
            var avg = collection.Average();
            var result = collection.Select(x => Math.Pow(x - avg, 2)).Average();
            return result;
        }
    }

    class Rainfall
    {
        public static IEnumerable<double> gett(string t, string s) => s.Split('\n').First(x => x.Contains(t)).Split(',').Select(x => Convert.ToDouble(x));
        public static double Mean(string town, string strng)
        {
            return strng.Contains(town + ":") ? gett(town, strng).Average() : -1;
        }

        public static double Variance(string town, string strng)
        {
            var avg = Mean(town, strng);
            return strng.Contains(town + ":") ? gett(town, strng).Select(x => Math.Pow(x - avg, 2)).Average() : -1;
        }
    }
}
