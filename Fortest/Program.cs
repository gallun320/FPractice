using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //Race(80, 91, 37);
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
            Console.WriteLine(Solution(72.2469839138198));
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

        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2) return null;

            var vtotal = v2 - v1;

            var t = (float)g / vtotal;

            var hours = (int)Math.Round(t);
            var minute = (int)(t / 60);
            var second = (int)(t / 100);

            Console.WriteLine($"{hours} {minute} {second}");

            return new int[3] { hours, minute, second };
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

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            
            return a.Concat(b).Distinct().ToArray();
        }
    }
}
