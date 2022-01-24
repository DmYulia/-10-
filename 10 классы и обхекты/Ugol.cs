using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_классы_и_обхекты
{
    class Ugol
    {
        public int gradus, min, sec;
        public Ugol(int gradus, int min, int sec)
        {
            /*try
            {
                if (gradus < 0)
                {
                    throw new Exception("Некорректные данные!");
                }
                if ((min < 0)|(min > 60))
                {
                    throw new Exception("Некорректные данные!"); 
                }
                if ((sec < 0) | (sec > 60))
                {
                    throw new Exception("Некорректные данные!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }
        public double ToRadians()
        {
            return (((gradus + min/60.0 + sec/3600.0)*Math.PI)/180.0);
        }

    }
}
