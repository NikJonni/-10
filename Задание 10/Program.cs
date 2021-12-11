using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{

    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Введите данные: ");
                Console.Write("Градусы: ");
                double grad = Convert.ToDouble(Console.ReadLine());
                Console.Write("Минуты: ");
                double min = Convert.ToDouble(Console.ReadLine());
                Console.Write("Секунды: ");
                double sec = Convert.ToDouble(Console.ReadLine());
                Angle an = new Angle(grad, min, sec);
                Console.WriteLine("Радианы = {0:f4}", an.ToRadians(grad, min, sec));
                Console.WriteLine("                                  Нажмите ENTER");
                Console.ReadKey();
            }
        }
    }
    class Angle
    {
        public double degrees;
        public double minutes;
        public double Seconds { get; set; }
        public double Degrees
        {
            set
            {
                if (value >= 0 && value <= 360)
                {
                    degrees = value;
                }
                else
                {
                    Console.WriteLine("Введено неправильное значение");
                }
            }
            get
            {
                return degrees;
            }
        }
        public double Minutes
        {
            set
            {
                minutes = value % 60;
                degrees += value / 60;
            }
            get
            {
                return minutes;
            }
        }
        public Angle(double degrees, double minutes, double seconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }
        public double ToRadians(double degrees, double minutes, double seconds)
        {
            double rad = degrees * Math.PI / 180 + minutes * Math.PI / (180 * 60) + seconds * Math.PI / (180 * 60 * 60);
            return rad;
        }
    }
}

