using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//возьмем только положительные значения углов, минуты и секунды не больше 60.
namespace _10_классы_и_обхекты
{
    class Program
    {
        static void Main(string[] args)
        {
            int gr, m, s;
            Console.WriteLine("Введите размерность угла в целых числах:");
            G:
            try
            {
                Console.Write("Градусы: ");
                gr = Convert.ToInt32(Console.ReadLine());
                if (gr<0) throw new Exception("Некорректные данные!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                goto G;
            }
            M:
            try
            {
                Console.Write("Минуты: ");
                m = Convert.ToInt32(Console.ReadLine());
                if ((m < 0)|(m>60)) throw new Exception("Некорректные данные!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto M;
            }
            S:
            try
            {
                Console.Write("Секунды: ");
                s = Convert.ToInt32(Console.ReadLine());
                if ((s < 0) | (s > 60)) throw new Exception("Некорректные данные!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto S;
            }
            Ugol ug = new Ugol(gr, m, s);
            string q = string.Format("{0:f6}", ug.ToRadians());
            Console.WriteLine($"Введенный угол равен {q} радиан.");
            Console.ReadKey();
        }
    }
}
