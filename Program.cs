using System;
using System.Web;
using System.Text;

namespace URLTool
{
    internal class Program
    {
        readonly private static StringComparison o = StringComparison.OrdinalIgnoreCase;

        private static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                if (string.Equals(args[0], "decode", o))
                {
                    Console.WriteLine("\n" + HttpUtility.UrlDecode(args[1]));
                }
                else if (string.Equals(args[0], "encode", o))
                {
                    StringBuilder sb = new();
                    foreach (char c in args[1])
                    {
                        sb.AppendFormat("%{0:X2}", (int)c);
                    }
                    Console.WriteLine(Environment.NewLine + sb.ToString());
                }
                else
                {
                    Error();
                }
            }
            else
            {
                Error();
            }
        }

        private static void Error()
        {
            Console.WriteLine("\nUsage: URLTool <encode/decode> <string>");
        }
    }
}