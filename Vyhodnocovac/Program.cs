using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyhodnocovac
{
    public class Vyhodnotit
    {
        public double vyhodnotit(string a)
        {
            DataTable dt = new DataTable();
            return Convert.ToDouble(dt.Compute(a, "")); ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "2-1*8+16";
            Vyhodnotit A = new Vyhodnotit();
            Console.WriteLine(A.vyhodnotit(a));
            Console.ReadLine();
        }
    }
}
