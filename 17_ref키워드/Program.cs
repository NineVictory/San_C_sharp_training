using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ref키워드
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "before passing";
            int[] arr = { 10, 20, 30 };
            
            Test(s);
            Console.WriteLine(s);

            Test(ref s);
            Console.WriteLine(s);
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("{0}", arr[0]);

            Change(arr);
            Console.WriteLine("{0}", arr[0]);
        }

        public static void Test(string s) {

            s = "after passing";
        
        }

        public static void Test(ref string s)
        {

            s = "after passing";

        }

        private static void Change(int[] arr)
        {
            arr[0] = -10;
        }

    }
}
