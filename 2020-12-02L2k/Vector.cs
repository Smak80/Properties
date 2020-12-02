using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _2020_12_02L2k
{
    class Vector
    {
        private double[] values;

        public Vector(int n)
        {
            values = new double[n];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = i+1;
            }
        }
        
        public static Vector operator+(Vector v, double x)
        {
            Vector newv = new Vector(v.values.Length);
            for (int i = 0; i < newv.values.Length; i++)
            {
                newv[i] = v[i] + x;
            }
            return newv;
        }

        public static Vector operator +(double x, Vector v)
        {
            return v + x;
        }

        public double this[int i]
        {
            get
            {
                if (i >= 0 && i<values.Length)
                    return values[i];
                throw new IndexOutOfRangeException("Неверный индкес");
            }
            set
            {
                if (i >= 0 && i < values.Length)
                    values[i] = value;
                throw new IndexOutOfRangeException("Неверный индкес");
            }
        }
    }
}
