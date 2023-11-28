using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozellikler
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Ucgen
    {
        int a;
        int b;
        int c;

        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("hatali bilgi");
                else
                    a = value;
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("hatali bilgi");
                else
                    b = value;
            }
        }
        public int C
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("hatali bilgi");
                else
                    c= value;
            }
        }
    }
}
