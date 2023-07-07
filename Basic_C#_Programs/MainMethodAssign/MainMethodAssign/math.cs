using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssign
{
    public class math
    {
        // Defining three methods using various math operators and converting different data types 
        public int operation (int num)
        {
            return num * 13;
        }

        public int operation (decimal num)
        {
            return (int)(num / 3);
        }

        public int operation (string num)
        {
            int arg = Convert.ToInt32(num);
            return arg + 48;
        }
    }
}
