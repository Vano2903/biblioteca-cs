using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*TODO
 * aggiungere i controlli della setData()
*/

namespace biblioteca {
    class Data
    {
        private int d { get; set; }
        private int m { get; set; }
        private int y { get; set; }

        public Data()
        {
            d = 0;
            m = 0;
            y = 0;
        }

        public bool isEqual(Data secondDate)
        {
            if (d == secondDate.d && m == secondDate.m && y == secondDate.y)
            {
                return true;
            }
            return false;
        }

        public bool isNil()
        {
            if (d == 0 && m == 0 && y == 0)
            {
                return true;
            }
            return false;
        }

        public int maxDays() {
            if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                return 30;
            }
            else if (m == 2)
            {
                if (leapYear() == true)
                {
                    return 29;
                }
                return 28;
            }
            return 31;
        }

        public bool isValid()
        {
            if (m >= 1 && m <= 12)
            {
                if (d >= 1 && d <= maxDays())
                {
                    return true;
                }
            }
            return false;
        }

        public Data(int nd, int nm, int ny)
        {
            setData(nd, nm, ny);
        }

        public void setData(int d, int m, int y)
        {
            this.d = d;
            this.m = m;
            this.y = y;
        }

        public void Today()
        {
            string today = DateTime.Now.ToString("d/M/yyyy");
            string[] todays = today.Split('/');
            this.d = int.Parse(todays[0]);
            this.m = int.Parse(todays[1]);
            this.y = int.Parse(todays[2]);
        }

        public bool leapYear(){
            if ((y % 400 == 0 || y % 100 != 0) && (y % 4 == 0))
            {
                return true;
            }
            return false;
        }

        public Data addDays(int incDays)
        {
            int[] daysPerMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Data toAdd = this;

            for (int i = 0; i < incDays; i++)
            {

                if (toAdd.leapYear() == true)
                {
                    daysPerMonth[1] = 29;
                }
                else
                {
                    daysPerMonth[1] = 28;
                }
                toAdd.d++;

                if (toAdd.d > daysPerMonth[toAdd.m - 1])
                {
                    toAdd.d = 1;
                    toAdd.m++;
                    if (toAdd.m >= 13)
                    {
                        toAdd.m = 1;
                        toAdd.y++;
                    }
                }
            }

            return toAdd;
        }
    }
}