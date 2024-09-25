using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_1
{
    class Bread
    {
        public int counter;
    }

    static class Butter
    {
        public static int counter;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bread a = new Bread();
            a.counter = 5;
            Console.WriteLine("Bread: " + a.counter);

            Butter.counter = 7;

            Console.WriteLine("Butter: " + Butter.counter);
        }
    }
}
