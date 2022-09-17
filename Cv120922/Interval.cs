using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv120922
{
    internal class Interval
    {
        private int low;
        private int high;

        public Interval(int low, int high)
        {
            this.low = low;
            this.high = high;
        }
        public Interval() { }
        // find intersection between 2 intervals
        public static Interval? intersection(Interval i1, Interval i2)
        {
            if (i1.low > i2.low)
            {
                //swaping 
                Interval temp = new Interval();
                temp = i1;
                i1 = i2;
                i2 = temp;
            }

            Interval? prunik = null;
            if (i2.low > i1.low && i2.high < i1.high)
            {
                prunik = i2;
            } 
            else if(i1.high > i2.low)
            {
                prunik = new Interval(i2.low, i1.high);
                
            }
            return prunik;
        }
        
        public int Low { 
            get { return low; }
            set 
            {
                if (value >= high)
                {
                    throw new Exception("Low value must not be larger or equal to high value.");
                }
                low = value;
            }
        }
        public int High { 
            get { return high; }
            set { 
                if(value < low)
                {
                    throw new Exception("High value must not be smaller than low value");
                }
                high = value; 
            }
        }

        //display
        public override string ToString()
        {
            return "Interval <" + this.low + ", " + this.high + ">"; 
        }
    }
}
