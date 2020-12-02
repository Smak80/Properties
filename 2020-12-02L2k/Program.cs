using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_12_02L2k
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m1 = new Man("Ванька", new DateTime(2000, 5, 30), true);
            m1.Name = "Петька";
            Console.WriteLine(m1.Name);
            Console.WriteLine(m1.Age);
            try
            {
                m1.Birth = new DateTime(2010, 1, 14);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Man[] mans = new Man[3];
            for (int i = 0; i < mans.Length; i++)
            {
                mans[i] = m1;
            }

            foreach (var m in mans)
            {
                Console.WriteLine(m.Name);
            }

            int row = 3, col = 5;
            double[,] mtr = new double[row,col];

            double[][] smtr = new double[row][];
            smtr[0] = new double[col];
            smtr[1] = new double[col+3];


            Vector v = new Vector(10);
            Console.WriteLine(v[4]);
            Console.ReadKey();
        }
    }
}
