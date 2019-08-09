using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Fortest
{
    public class Program
    {
        private static object lockObject = new Object();
        static void Main(string[] args)
        {
            //Console.WriteLine(IsSquare(25));
            //Console.WriteLine(MaxNumber("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
            //Console.WriteLine(IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));
            //Console.WriteLine(Maskify("4556364607935616").Length);
            //int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            //int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            //Console.WriteLine(comp(a, b));
            //Console.WriteLine(GetSum(0, -1));
            //Console.WriteLine(GetMiddle("testing"));
            //Console.WriteLine(ToCamelCase("the-stealth-warrior"));
            //Console.WriteLine(StackCounting("([](){([])})"));
            //Console.WriteLine(print(5));
            //Console.WriteLine(FriendOrFoe(new string[] { "Ryan", "Kieran", "Mark", "Jimmy" }).ToArray().Length);
            //Race(639, 821, 73);
            //Console.WriteLine(CalculateYears(1000, 0.01625, 0.18, 1200));
            //Longest("inmanylanguages", "theresapairoffunctions");
            //Console.WriteLine(Encrypt("This is a test!", 2));
            //Console.WriteLine(Decrypt("hsi  etTi sats!", 1));
            //Console.WriteLine(BreakCamelCase("camelCasingTest"));
            //var arr = TwoSum(new[] { 1234, 5678, 9012 }, 14690);
            //Console.WriteLine(arr);
            //Console.WriteLine(MaxHeight(new int[] { 9, 7, 5, 5, 2, 9, 9, 9, 2, -1 }, -1));
            //Console.WriteLine(Disemvowel("This website is for losers LOL!"));
            //Console.WriteLine(TitleCase("THE WIND IN THE WILLOWS", "The In"));
            //Console.WriteLine(StockSummary(new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" }, new string[] { "A", "B" }));
            //Console.WriteLine(СhooseBestSum(331, 4, new List<int> { 91 , 74 , 73 , 85, 73, 81, 87 }));
            //TestCombinationsWithLinq();
            //StartCombinations();
            //GetCombination(new List<int> { 1, 2, 3, 4, 5 });
            /*var arr = UpArray(new int[] { 9, 9, 9 });
            foreach (var el in arr)
                Console.WriteLine(el);*/
            //Console.WriteLine(Solution(72.2469839138198));
            /*var arr = ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 });
            foreach (var el in arr)
                Console.WriteLine(el);*/
            //Console.WriteLine(ConvertToMixedNumeral("-504/26"));
            //Console.WriteLine(toFraction(-0.618103448275862));
            //fracion(1.75);
            //Ones(3);
            /*Operation op = new Multiply();
            op.Execute(3.0, 2.0);
            Console.WriteLine(op.Result);*/
            //var fn = Always(3);
            //Console.WriteLine(fn());
            //Console.WriteLine(fn());
            //Console.WriteLine(frac(-0.618103448275862));
            //Console.WriteLine(toFractionEnd(0.5));
            //var nodes = Nodes.Length(new Nodes(99));
            //Console.WriteLine(nodes);
            //Console.WriteLine(hydrate("5 asdgfdg 1 gfhgfh"));
            //Console.WriteLine(Persistence(999));
            /*var rs = TowerBuilder(3);
            foreach(var el in rs)
            {
                Console.WriteLine(el);
            }*/

            /*var rs = TowerBuilderThreads(3);
             foreach (var el in rs)
             {
                 Console.WriteLine(el);
             }*/

            /*ThreadTest tt = new ThreadTest();
            new Thread(ThreadTest.Go).Start();
            ThreadTest.Go();*/
            //Console.WriteLine(repeatStr(3, "I"));
            //ThreadTest.DelegateTest();
            //Console.WriteLine(MixedFraction("2/-7"));
            /*var c = cartesianNeighbor(2, 2);
            foreach(var el in c)
            {
                Console.WriteLine(el);
            }*/
            //IsLucky(100);
            //Console.WriteLine(GetLuckyTicket(32683));
            //Console.WriteLine(digPow(46288, 5));
            //Console.WriteLine(ToWeirdCase("This"));
            //var prc = new Plugboard("AB");
            //Console.WriteLine(prc.process('C'));
            //Console.WriteLine(stat(""));
            //Console.WriteLine(MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
            Console.WriteLine(1.FeetToCentimeters());
            Console.ReadKey();
            
        }

        static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }

        static string MaxNumber(string numbers)
        {
            var n = numbers.Split();
            Array.Sort(n);
            Console.WriteLine(string.Join(" ", n));
            var max = n[n.Length - 1];
            var min = n[0];
            return string.Format("{0} {1}", max, min);

        }

        static bool IsValidWalk(string[] walk)
        {
            var n = new Dictionary<string, int>();

            foreach(var letter in walk)
            {
                if(n.TryGetValue(letter, out var num))
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

        public static string Maskify(string cc)
        {
            if (cc.Length <= 4) return cc;
            Console.WriteLine(cc.Length);
            return cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#');
        }
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null) return false;
            if (a.Length == 0 || b.Length == 0) return false;

            Array.Sort(a);
            Array.Sort(b);
            var result = a.Select(x => x * x).SequenceEqual(b);
            return result;
        }


        public static int GetSum(int a, int b)
        {
            return (a + b) * (Math.Abs(a - b) + 1) / 2;
        }

        public static string GetMiddle(string s)
        {
            var idx = (s.Length / 2) - Math.Abs((s.Length % 2) - 1);
            return (idx != s.Length / 2) ? $"{s[idx]}{s[idx + 1]}" : $"{s[idx]}";
        }

        public static string ToCamelCase(string str)
        {
            var b = str.Replace("-", " ").Replace("_", " ").Split(' ').Select((item, index) => {
                if (index < 1) return item;
                return char.ToUpper(item[0]) + item.Substring(1);
            });
            return string.Join("",b);
        }

        public static string MYprint(int n)
        {
            if ((n % 2) == 0 || n < 0) return null;

            var rstr = new StringBuilder();
            var stbuilder = "";
           for (var i = Math.Ceiling(n / 2.0d); i < n; i++)
            {
                stbuilder = "".PadRight(Math.Abs((int)i - n));
                stbuilder = stbuilder.PadRight((int)i, '*');
                stbuilder += "\n";
                rstr.Append(stbuilder);
            }
            
            
            rstr.Append("\n".PadLeft(n + 1, '*'));

            for (int i = n - 1, j = (int)Math.Ceiling(n / 2.0d) - 1; i > j; i--)
            {
                stbuilder = "".PadRight(Math.Abs(i - n));
                stbuilder = stbuilder.PadRight(i, '*');
                stbuilder += "\n";
                rstr.Append(stbuilder);
            }

            return rstr.ToString();
        }

        public static string print(int n)
        {
            if (n % 2 == 0 || n < 0) return null;

            var middle = n / 2;
            var sb = new StringBuilder();
            for(var idx = 0; idx < n; ++idx)
            {
                sb.Append(' ', Math.Abs(middle - idx));
                sb.Append('*', n - Math.Abs(middle - idx) * 2);
                sb.Append('\n');
            }
            return sb.ToString();
        }

        public static string StackCounting(string str)
        {
            char[] stack = new char[str.Length];
            int[] stackIndex = new int[str.Length];
            int top = 0;



            for(var i = 0; i < str.Length; ++i)
            {
                var chunk = str[i];
                if(chunk == '(' || chunk == '[' || chunk == '{')
                {
                    stack[top] = chunk;
                    stackIndex[top++] = i + 1;         
                }
                else 
                {
                    
                    if (chunk == ')' || chunk == ']' || chunk == '}')
                    {
                        if (top == 0) return (i + 1).ToString();

                        var pop = stack[top - 1];
                        if ((pop == '(' && chunk == ')') || (pop == '[' && chunk == ']') || (pop == '{' && chunk == '}'))
                        {
                            stack[top - 1] = '\0';
                            stackIndex[--top] = 0;
                        }
                        else
                        {
                            return (i + 1).ToString();
                        }
                    }
                }
            }

            if(top == 0)
            {
                return "Succeed";
            }
            else
            {
                return stackIndex[top - 1].ToString();
            }
        }
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            lock(lockObject)
            {
                return names.Where(name => name.Length == 4);
            }
        }

        public static int[] MYRace(int v1, int v2, int g)
        {
            if (v1 >= v2) return null;

            var vtotal = Convert.ToDouble(v2) - Convert.ToDouble(v1);

            var t = (double)g / vtotal;

            var hours = (int)t;
            var minute = ((t - (int)t) * 60); 
            var second = (int)((minute - (int)minute) * 60 + 0.000000001);

           if (second > 59)
           {
                second = 0;
                ++minute;
           }

           if ((int)minute > 59)
           {
                minute = 0;
                ++hours;
           }

            return new int[3] { hours, (int)minute, (int)second };
        }

        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2) return null;

            var t = TimeSpan.FromSeconds((g * 3600) / (v2 - v1));

            return new int[3] { t.Hours, t.Minutes, t.Seconds };
        }

        public static int MYCalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            if (principal == desiredPrincipal) return 0;
            var lcPrincipal = principal;
            var year = 0;
            while(true)
            {
                var pr = lcPrincipal* interest;
                pr = pr - (pr * tax);
                lcPrincipal += pr;
                ++year;
                if (lcPrincipal >= desiredPrincipal) return year;
            }
        }

        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            return (int)Math.Ceiling(Math.Log(desiredPrincipal / principal, 1 + (interest * (1 - tax))));
        }

        public static string MYLongest(string s1, string s2)
        {
            var set1 = new SortedSet<char>(s1.ToCharArray());
            var set2 = new SortedSet<char>(s2.ToCharArray());
            set1.UnionWith(set2);
            return string.Join("", set1);
        }

        public static string Longest(string s1, string s2)
        {
            return new string((s1 + s2).Distinct().OrderBy(x => x).ToArray());
        }

        public static string MYEncrypt(string text, int n)
        {
            if (n < 1 || text == null) return text;
            StringBuilder s1 = new StringBuilder();
            StringBuilder s2 = new StringBuilder();
            for(var j = 0; j < n; ++j)
            for(var i = 0; i < text.Length; ++i)
            {
                if((i % 2) == 0)
                {
                    s1.Append(text[i]);
                }
                else if((i % 1) == 0)
                {
                    s2.Append(text[i]);
                }
            }
            n--;
            return  s2.Append(s1).ToString();
        }

        public static string MYDecrypt(string encryptedText, int n)
        {
            if (n < 1 || encryptedText == null) return encryptedText;
            string s1 = encryptedText.Substring(encryptedText.Length / 2);
            string s2 = encryptedText.Substring(0, encryptedText.Length / 2);
            StringBuilder sresult = new StringBuilder();

            for (var j = 0; j < n; ++j)
            for (var i = 0; i < encryptedText.Length / 2 + 1; ++i)
            {
                if(i < s1.Length) sresult.Append(s1[i]);
                if(i < s2.Length)  sresult.Append(s2[i]);
            }

            return sresult.ToString();
        }

        public static string Encrypt(string text, int n)
        {  
            return new string(text.Where((x, i) => (i % 2) == 0).Concat(text.Where((x, i) => (i % 1) == 0)).ToArray());
        }

        public static string Decrypt(string encryptedText, int n)
        {
            if (n < 1 || encryptedText == null) return encryptedText;
            string s1 = encryptedText.Substring(encryptedText.Length / 2);
            string s2 = encryptedText.Substring(0, encryptedText.Length / 2);
            StringBuilder sresult = new StringBuilder();

            for (var j = 0; j < n; ++j)
                for (var i = 0; i < encryptedText.Length / 2 + 1; ++i)
                {
                    if (i < s1.Length) sresult.Append(s1[i]);
                    if (i < s2.Length) sresult.Append(s2[i]);
                }

            return sresult.ToString();
        }

        public static string OddOrEven(int[] array)
        {
            return (array.Sum() % 2) == 0 ? "even" : "odd";
        }

        public static string MYBreakCamelCase(string str)
        {
            var arr = new char[str.Length * 2];
            var idx = 0;
            var point = 0;

            while (point < str.Length)
            {

                if (str[point] < 97)
                {
                    arr[idx++] = ' ';
                    arr[idx++] = str[point];
                }
                else
                {
                    arr[idx++] = str[point];
                }
                ++point;
            }

            return string.Join("", arr.Take(idx));
        }

        public static string BreakCamelCase(string str)
        {
            var strBuilder = new StringBuilder();

            foreach(var ch in str)
            {
                if (ch < 97) strBuilder.Append(' ');
                strBuilder.Append(ch);
            }

            return strBuilder.ToString();
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            var first = 0;
            var rsarr = new int[2];
            while(true)
            {
                var el = target - numbers[first];
                var second = Array.LastIndexOf(numbers,el);
                if(second != -1)
                {
                    rsarr[0] = first;
                    rsarr[1] = second;
                    break;
                }
                ++first;
            }

            return rsarr;
        }

        public static string MYDisemvowel(string str)
        {
            var chrem = new char[] { 'a', 'e', 'i', 'o', 'u' };
            return new string(str.Where(x => Array.IndexOf(chrem, char.ToLower(x)) == - 1).ToArray());
        }

        public static string Disemvowel(string str)
        {
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }

        public static string TitleCase(string title, string minorWords = "")
        {
            if (title.Length == 0) return "";
            var minorArr = string.IsNullOrEmpty(minorWords) ? new string[1] {""} : minorWords.ToLower().Split(' ');
            return string.Join(" ", title.Split(' ').Select((x, i) => {
                x = x.Replace(x, x.ToLower());
                if (Array.IndexOf(minorArr, x) == -1 || i == 0)
                {

                    x = char.ToUpper(x[0]) + x.Substring(1);
                }
                return x;
            }).ToArray());
        }

        public static string StockSummary(string[] lstOfArt, string[] lstOf1stLetter)
        {
            if (lstOfArt.Length == 0) return string.Empty;
            var arr = new string[lstOf1stLetter.Length];
            for(var i = 0; i < lstOf1stLetter.Length; ++i)
            {
                var bookSum = lstOfArt.Where(x => x[0] == lstOf1stLetter[i][0]).Select(x => int.Parse(Regex.Match(x, @"\d+").Value)).Sum();
                arr[i] = $"({lstOf1stLetter[i]} : {bookSum})";
            }
            return string.Join(" - ", arr);
        }

        public static int? СhooseBestSum(int t, int k, List<int> ls)
        {

            Func<int, int> factorial = (int a) =>
             {
                 var res = 1;
                 while (a > 0)
                 {
                     res *= a--;
                 };
                 return res;
             };

            var countCombinations = (factorial(ls.Count) / (factorial(k) * factorial(ls.Count - k)));

            if (ls == null || ls.Count < 2) return null;

            var rg = Enumerable.Range(0, k).ToArray();
            var endResult = new List<int>();
            var size = ls.Count;

            
            do
            {
                var sm = rg.Select(x => ls[x]).Sum();
                if(sm <= t)
                {
                    endResult.Add(sm);
                }
                var i = k - 1;
                while (true)
                {
                
                    if(rg[i] < size - 1 - (k - 1) + i)
                    {
                        rg[i]++;
                        if (i < k - 1)
                            for (var j = i + 1; j < k; ++j)
                                rg[j] = rg[j - 1] + 1;
                        else
                            break;
                    }
                    if (i-- == 0) break;
                }
            } while (rg[0] < size - 1 - (k - 1) + 0);

            /*foreach (int i in endResult)
                Console.WriteLine($"{i} : {endResult.Count}");*/

            var arr = endResult.ToArray();
            Array.Sort(arr);
            if (arr[arr.Length - 1] <= t)
            {
                return arr[arr.Length - 1];
            }
            else
            {
                return null;
            }
        }

        public static int MaxHeight(int[] arr, int parent)
        {
            var idx = Array.IndexOf(arr, parent);
            if (idx == -1) return 0;
            var height = 1;
            foreach(var ch in arr.Select((x,i) => { return (x == idx) ? i : -2; }))
            {
                if(ch != -2)
                {
                    var heightTmp = 1 + MaxHeight(arr, ch);
                    height = (height < heightTmp) ? heightTmp : height;
                }
            }
            return height;
        }

        delegate void Del();
        public static void TempAnonymousChecking()
        {
            var n = new int[] { 0, 1, 2, 3, 4 };
            Del d = delegate () {
                n = new int[] { 0, 1, 5, 5, 5, 6 };
                Console.WriteLine("Copy #:{0}", n);
            };
        }


        public static void TestCombinationsWithLinq()
        {
            List<String> list = new List<String> { "a", "b", "c" };

            

            var result = Enumerable.Range(1, (1 << list.Count) - 1);

            

            result.Select(index => list.Where((item, idx) => ((1 << idx) & index) != 0).ToList());

            Console.WriteLine(String
                .Join(Environment.NewLine, result
                .Select(line => String.Join(", ", line))));
        }

        public static bool NextCombination(IList<int> num, int n, int k)
        {
            bool finished;

            var changed = finished = false;

            if (k <= 0) return false;

            for (var i = k - 1; !finished && !changed; i--)
            {
                if (num[i] < n - 1 - (k - 1) + i)
                {
                    num[i]++;

                    if (i < k - 1)
                        for (var j = i + 1; j < k; j++)
                            num[j] = num[j - 1] + 1;
                    changed = true;
                }
                finished = i == 0;
            }

            return changed;
        }

        public static IEnumerable Combinations<T>(IEnumerable<T> elements, int k)
        {
            var elem = elements.ToArray();
            var size = elem.Length;

            if (k > size) yield break;

            var numbers = new int[k];

            for (var i = 0; i < k; i++)
                numbers[i] = i;

            do
            {
                yield return numbers.Select(n => elem[n]);
            } while (NextCombination(numbers, size, k));
        }

        public static void StartCombinations()
        {
            const int k = 3;
            var n = new[] { "12", "23", "43", "54", "15" };

            Console.Write("n: ");
            foreach (var item in n)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("k: {0}", k);
            Console.WriteLine();


            foreach (IEnumerable<string> i in Combinations(n, k))
                Console.WriteLine(string.Join(" ", i));
        }

        private static int Factorial(int a)
        {
            var res = 1;
            while (a > 0)
            {
                res *= a--;
            };
            return res;
        }

        static void GetCombination(List<int> list)
        {
            double count = Math.Pow(2, list.Count);
            for (int i = 1; i <= count - 1; i++)
            {
                string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        Console.Write(list[j]);
                    }
                }
                Console.WriteLine();
            }
        }

        public static int[] MYUpArray(int[] num)
        {
            var last = num.Length - 1;

            if (num.Length == 0 || num.Min() < 0 || num.Max() > 9) return null;
            do
            {
                if (last < 0)
                {
                    var newArr = new int[num.Length + 1];
                    newArr[0] = 1;
                    num.CopyTo(newArr,1);
                    return newArr;
                }
                if (num[last] < 0 || num[last] > 9) return null;
                if (num[last] + 1 > 9)
                {
                    num[last] = 0;


                }
                else
                {
                    num[last] += 1;
                }
            } while (num[last--] == 0);

            return num;
        }

        public static int[] UpArray(int[] num)
        {
            if (num.Length == 0 || num.Any(x => x < 0 || x > 9)) return null;

            for(var i = num.Length - 1; i > -1; --i)
            {
                if(num[i] == 9)
                {
                    num[i] = 0;
                }
                else
                {
                    ++num[i];
                    return num;
                }
            }

            return new [] { 1 }.Concat(num).ToArray();
        }

        public static double Solution(double n)
        {
            return Math.Round(n * 2, MidpointRounding.AwayFromZero) / 2;
        }

        public static int[] MYArrayDiff(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0) return a;
            return a.Where(x => Array.IndexOf(b, x) == -1).Select(x => x).ToArray();
        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0) return a;
            return a.Where(x => !b.Contains(x)).ToArray();
        }

        public static string MYConvertToMixedNumeral(string frac)
        {
            var statement = frac.Split('/');
            var fPart = double.Parse(statement[0]);
            var sPart = double.Parse(statement[1]);

            var full = fPart / sPart;

            var result = Math.Abs(Math.Round(( full - ((int)full)) * sPart));

            if (fPart < 0 && (int)full == 0) result *= -1;

            var firstPart = ((int)full != 0) ? ((int)full).ToString() + " " : "";
            var secondPart = (result != 0) ? $"{result}/{sPart}" : "";

            return (firstPart + secondPart).TrimEnd();
        }

        public static string ConvertToMixedNumeral(string frac)
        {
            var statement = frac.Split('/');
            var fPart = int.Parse(statement[0]);
            var sPart = int.Parse(statement[1]);

            var full = fPart / sPart;
            var result = fPart % sPart;

            return result == 0 ? full.ToString() : result != 0 && full != 0 ? $"{full} {Math.Abs(result)}/{sPart}" : frac;
        }

        public static string toFraction(double number)
        {
            if (number == Math.Floor(number)) return number.ToString();
            var start = (int)number;
            var x = number - start;
            var vectorNum = new List<int>();
            do
            {
                Console.WriteLine((int)(1 / x));
                var middle = (int)(1 / x);
                x = (1 / x) - (double)middle;
                vectorNum.Add(middle);
                if ((x * 10) < 1) x = 0;
            } while (x != 0);

            if(vectorNum.Count == 1)
            {
                return $"{Math.Floor((double)vectorNum.Last() / 10) + Math.Ceiling((double)vectorNum.Last() / 10)}/{Math.Abs(vectorNum.Last())}";
            }

            var tmp = 0;
            for(var i = vectorNum.Count - 1; i != 0; --i)
            {
                tmp += 1 + ((i - 1 > -1) ? vectorNum[i - 1] : 0) * vectorNum[i]; 
            }

            var upEl = start * tmp + vectorNum.Last();
            return $"{upEl}/{tmp}";
        }

        public static void fracion(double x)
        {
            var a = "" + x;
            var spilts = a.Split(','); // split using decimal
            var b = spilts[1].Length; // find the decimal length
            var denominator = (long)Math.Pow(10, b); // calculate the denominator
            var numerator = (long)(x * denominator); // calculate the nerumrator Ex
                                                    // 1.2*10 = 12
            var gcd = getGCD(numerator, denominator); // Find the greatest common
                                                      // divisor bw them
            string fraction = numerator / gcd + "/" + denominator / gcd;
            Console.WriteLine(fraction);
        }

        public static long getGCD(long n1, long n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            return getGCD(n2, n1 % n2);
        }

        public static string frac(double n)
        {
            var c = n.ToString().Split(',');
            var f = c[0];
            var s = c[1];
            var numerator = (int)long.Parse(s);
            var denominator = (int)Math.Pow(10, s.Length);

            var rs = Gcd(numerator, denominator);

            var end = (numerator / rs) / 2 + "/" + (denominator / rs) / 2;

            return end;
        }


        public static int Gcd(int num1, int num2)
        {
            if (num2 == 0) return num1;
            return Gcd(num2, num1 % num2);
        }

        public static string toFractionEnd(double n)
        {
            if (n % 1 == 0) return "" + n;
            for(var i = 1; i < 2000; ++i)
            {
                var tmp = Math.Abs(Math.Round(n * i) - n * i);
                if (tmp < 0.000000001) return $"{n * i}/{i}";
            }
            return "" + n;
        }

        public static int Ones(long n)
        {
            return Convert.ToString(n,2).Select(x => x - 48).Sum();
        }

        public static Func<int> Always(int n) => () => n;


        public static string MYGetLuckyTicket(int index) // TODO
        {
            
            var endList = new List<string>();
            foreach(var str in CreateLuckyArr())
            {
                var f = str.Substring(0, 3);
                var s = str.Substring(3, 3);

                var fr = (f[0] - 48) + (f[1] - 48) + (f[2] - 48);
                var sr = (s[0] - 48) + (s[1] - 48) + (s[2] - 48);

                if(fr == sr)
                {
                    endList.Add(str);
                }
            }

            if (index < 0 || index > endList.Count)
                return "Wrong index!";
            else
                return endList[index];
        }

        public static IEnumerable<string> CreateLuckyArr()
        {
            return Enumerable.Range(0, 999999).Select(x => x.ToString().PadLeft(6, '0'));
        }

        public static string GetLuckyTicket(int index) // TODO
        {
            int temp = 0;
            for(var i = 0; i < 1000000; ++i)
            {
                var ticket = i.ToString().PadLeft(6, '0');
                var fr = (ticket[0] - 48) + (ticket[1] - 48) + (ticket[2] - 48);
                var sr = (ticket[3] - 48) + (ticket[4] - 48) + (ticket[5] - 48);
                if ((fr == sr) && temp++ == index) return ticket;
            }
            return "Wrong index";
        }

        public static string hydrate(string drinkString)
        {
            // Insert party here
            var rs = Regex.Replace(drinkString, "[a-z, ]", "", RegexOptions.IgnoreCase).Select(x => x - 48).Sum();
            return rs > 1 ? rs + " glasses of water" : rs + " glass of water";
        }

        public static int MYPersistence(long n)
        {
            var rs = new List<long>();
            while(n > 9)
            {
                var tmp = 1;
                foreach(var i in n.ToString().Select(x => x - 48))
                {
                    tmp *= i;
                }
                n = tmp;
                rs.Add(n);
            }

            return rs.Count();
        }

        public static int Persistence(long n)
        {
            var count = 0;
            while (n > 9)
            {
                ++count;
                n = n.ToString().Select(x => x - 48).Aggregate((x, y) => x * y);
            }

            return count;
        }

        public static string[] MYTowerBuilder(int nFloors)
        {
            var strArr = new string[nFloors];
            var maxCount = nFloors + (nFloors - 1);
            var idx = 0;
            var str = new StringBuilder();
            for(var i = 1; i < maxCount + 1; i += 2)
            {
                str.Append(' ', (maxCount - i) / 2);
                str.Append('*', i);
                str.Append(' ', (maxCount - i) / 2);
                strArr[idx] = str.ToString();
                str.Clear();
                ++idx;

            }
            return strArr;
        }

        public static string[] TowerBuilder(int nFloors)
        {
            return Enumerable.Range(1, nFloors).Select(x => new string(' ', nFloors - x) + new string('*', x * 2 - 1) + new string(' ', nFloors - x)).ToArray();
        }

        static StringBuilder _strTower = new StringBuilder();
        static object _lockObj = new object();

        public static string[] TowerBuilderThreads(int nFloors)
        {
            var strArr = new string[nFloors];
            var maxCount = nFloors + (nFloors - 1);
            var idx = 0;
            var str = new StringBuilder();
            for (var i = 1; i < nFloors + 1; ++i)
            {
                var tr1 = new Thread(() => AppenedSpaces(nFloors, i));
               var tr2 = new Thread(new ParameterizedThreadStart(AppendStars));
                var tr3 = new Thread(() => AppenedSpaces(nFloors, i));
                var tr4 = new Thread(() => ClearBuilder());

                tr1.Start();
                tr1.Join();
                tr2.Start(i);
                tr2.Join();
                tr3.Start();
                tr3.Join();
                strArr[idx] = _strTower.ToString();
                tr4.Start();
                tr4.Join();

                ++idx;

            }
            return strArr;
        }

        public static void AppenedSpaces(int nFloors, int counter)
        {
            lock(_lockObj)
            {
                _strTower.Append(' ', nFloors - counter);
            }
        }

        public static void AppendStars(int counter)
        {
            lock(_lockObj)
            {
                _strTower.Append('*', counter * 2 - 1);
            }      
        }

        public static void AppendStars(object counter)
        {
            lock (_lockObj)
            {
                _strTower.Append('*', (int)counter * 2 - 1);
            }
        }

        public static void ClearBuilder()
        {
            lock(_lockObj)
            {
                _strTower.Clear();
            }
        }

        public static string repeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Range(1, n).Select(x => s).ToArray());
        }

        public static string MYMixedFraction(string s)
        {
            var numbs = s.Split('/');
            var f = Convert.ToInt32(numbs[0]);
            var n = Convert.ToInt32(numbs[1]);


            var full = f / n;
            if (f == 0) return f.ToString();
            var second = f % n;

            for(var i = 2; i < 10000000; ++i)
            {
                if(second % i == 0 && n % i == 0)
                {
                    second /= i;
                    n /= i;
                    NearestSlice(ref second, ref n, i);
                }
            }

            if (n < 0) second *= -1;

            return second != 0 && full != 0 ? $"{full} {Math.Abs(second)}/{Math.Abs(n)}" : full != 0 && second == 0 ? full.ToString() : $"{second}/{Math.Abs(n)}";
        }

        public static void NearestSlice(ref int num1, ref int num2, int counter)
        {
            if (num1 % counter == 0 && num2 % counter == 0)
            {
                num1 /= counter;
                num2 /= counter;
                NearestSlice(ref num1, ref num2, counter);
            }
        }

        public static string MixedFraction(string s)
        {
            var numer = Convert.ToInt64(s.Split('/')[0]);
            var denom = Convert.ToInt64(s.Split('/')[1]);

            if(denom < 0)
            {
                numer *= -1;
                denom *= -1;
            }

            if (denom == 0)
                throw new DivideByZeroException();

            Func<long, long, long> gcd = null;
            gcd = (a, b) => (b == 0) ? a : gcd(b, a % b);

            if (numer % denom != 0)
                return string.Format("{0} {1}/{2}", numer / denom == 0 ? string.Empty : (numer / denom).ToString(),
                                                    numer / denom == 0 ? (numer % denom) / Math.Abs(gcd.Invoke(numer, denom)) : Math.Abs((numer % denom) / gcd.Invoke(numer, denom)),
                                                    numer / denom == 0 ? denom / Math.Abs(gcd.Invoke(numer, denom)) : Math.Abs(denom / gcd.Invoke(numer, denom))).Trim();
            else
                return (numer / denom).ToString();
        }


        public static string CovertirKilometrosAMillas(string km)
        {
            if (km == "0") return "0.00";
            return (Math.Round(Convert.ToDouble(km) * 0.62137, 2)).ToString();
        }

        public static IEnumerable<int[]> MYcartesianNeighbor(int x, int y)
        {
            for(var i = -1; i < 2; ++i)
            {
                for (var j = -1; j < 2; ++j)
                {
                    if (x == x - i && y == y - j) continue;
                    yield return new int[] { x - i, y - j };
                    
                }
            }
        }

        public static IEnumerable<int[]> cartesianNeighbor(int x, int y)
        {
            return Enumerable.Range(x - 1, 3).SelectMany(xn => Enumerable.Range(y - 1, 3).Where(yn => xn != x || yn != y).Select(yn => new int[] { xn, yn }));
        }

        public static long MYdigPow(int n, int p)
        {
            var str = n.ToString();
            long tmp = 0;
            foreach(var ch in str)
            {
                tmp += (long)Math.Pow((ch - 48),  p++);
            }
            var r = tmp / n;
            return r == 0 || tmp != r * n ? -1 : r;
        }

        public static long digPow(int n, int p)
        {
            var sum = Convert.ToInt64(n.ToString().Select(x => Math.Pow((x - 48), p++)).Sum());
            return sum % n == 0 ? sum / n : -1;
        }

        public static string MakeComplement(string dna)
        {
            var swDictionary = new Dictionary<char, char>() { { 'A', 'T' }, { 'T', 'A' }, { 'G', 'C' }, { 'C', 'G' } };
            return new string(dna.Select(x => swDictionary[x]).ToArray());
        }

        public static string ToWeirdCase(string s)
        {
            return string.Join(" ", s.Split(' ').Select(j => new string(j.Select((x, i) => i % 2 == 0 ? char.ToUpper(x) : char.ToLower(x)).ToArray())).ToArray());
        }

        public static string SpinWords(string sentence) => string.Join(" ", sentence.Split(' ').Select(x => x.Length > 4 ? new string(x.Reverse().ToArray()) : x).ToArray());

        public static string stat(string strg)
        {
            if (string.IsNullOrEmpty(strg)) return string.Empty;
            var times = strg.Replace("|", ":").Split(',').Where(x => x.Length > 6).Select(x => DateTime.Parse(x).TimeOfDay).OrderBy(x => x).ToArray();
            var rg = new DateTime() + (times[times.Length - 1] - times[0]);
            var dd = 0d;
            var count = times.Length;
            for (var i = 0; i < count; ++i)
            {
                dd += times[i].Ticks / (double)count;
            }
            var av = new DateTime((long)dd);
            TimeSpan men = new TimeSpan();
            if (count % 2 != 0)
            {
                men = times[count / 2];
            }
            else
            {
                var mg = (times[count / 2] + times[count / 2 - 1]).TotalMilliseconds / 2;
                men = new DateTime((long)(mg * 10000)).TimeOfDay;
            }
            return $"Range: {rg.TimeOfDay.ToString("hh\\|mm\\|ss")} Average: {av.TimeOfDay.ToString("hh\\|mm\\|ss")} Median: {men.ToString("hh\\|mm\\|ss")}";
        }

        public static int[] GetRow(int rowNumber)
        {
            if (rowNumber == 0) return new int[] { };
            if (rowNumber == 1) return new int[] { 1 };
            Func<List<int>, List<int>> pascalTriangle = null;
            /*pascalTriangle = (List<int> arr) =>
            {
                if (arr.Count == rowNumber) return arr; 

                for()
            }*/


            return new int[] { };
        }


        public static string ToJadenCase(string phrase)
        {
            return string.Join(" ", phrase.Split(' ').Select(x => char.ToUpper(x[0]) + x.Substring(1)).ToArray());
        }

        public static int MaxSequence(int[] arr)
        {
            if (arr.Length == 0) return 0;
            var sum = 0;
            var max = arr[0];
            foreach( var num in arr)
            {
                sum += num;
                max = Math.Max(max, sum);
                sum = Math.Max(sum, 0);
            }

            return max;
        }

        public static int[] MaxSum(int[][] input)
        {
            return new int[0];
        }

        public static decimal Round(decimal number, int precision, int roundUpAt)
        {
            return 0m;
        }
    }
}
