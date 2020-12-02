using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_12_02L2k
{
    class Man
    {
        private DateTime birth;
        private bool gender;

        public Man(string name, DateTime birth, bool gender)
        {
            Name = name;
            this.birth = birth;
            this.gender = gender;
        }
        
        public string Name
        {
            get;
            set;
        }

        public DateTime Birth
        {
            get
            {
                return birth;
            }
            set
            {
                if (DateTime.Today.Year - value.Year >= 14)
                {
                    birth = value;
                }
                else
                    throw new Exception("Маловат!");
            }
        }

        public int Age
        {
            get
            {
                return (DateTime.Today.Year - birth.Year) -
                    ((DateTime.Today.Month < birth.Month ||
                     (DateTime.Today.Month == birth.Month && DateTime.Today.Day < birth.Day))
                        ? 1
                        : 0);
            }
        }



    }
}
