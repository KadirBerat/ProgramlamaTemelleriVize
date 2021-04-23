using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.ProgramlamaTemelleriVize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.NewLine + "-----" + Environment.NewLine + "Soru 1" + Environment.NewLine + "-----");
            Question1();
            Console.WriteLine(Environment.NewLine + "-----" + Environment.NewLine + "Soru 2" + Environment.NewLine + "-----");
            Question2();
            Console.ReadKey();
        }

        public static string GetRegion(short x, short y)
        {
            string result = String.Empty;
            if (x == 0 && y == 0)
            {
                result = "(0,0) => Orijin üzerinde.";
            }
            else if (x == 0 && y != 0)
            {
                if (y > 0)
                    result = $"(0,{y}) => Y ekseni üzerinde, pozitif tarafta.";
                else if (y < 0)
                    result = $"(0,{y}) => Y ekseni üzerinde, negatif tarafta.";
            }
            else if (x != 0 && y == 0)
            {
                if (x > 0)
                    result = $"({x},0) => X ekseni üzerinde, pozitif tarafta.";
                else if (x < 0)
                    result = $"({x},0) => X ekseni üzerinde, negatif tarafta.";
            }
            else
            {
                if (x > 0 && y > 0)
                    result = $"({x},{y}) => I. Bölgede";
                else if (x > 0 && y < 0)
                    result = $"({x},{y}) => IV. Bölgede";
                else if (x < 0 && y > 0)
                    result = $"({x},{y}) => II. Bölgede";
                else if (x < 0 && y < 0)
                    result = $"({x},{y}) => III. Bölgede";
            }
            return result;
        }

        public static void Question1()
        {
            short x, y;
            Console.WriteLine("X dedğerini girin: ");
            try
            {
                x = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı giriş yaptığınız için program sonlandı.");
                return;
            }
            Console.WriteLine("Y dedğerini girin: ");
            try
            {
                y = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı giriş yaptığınız için program sonlandı.");
                return;
            }
            string response = GetRegion(x, y);
            Console.WriteLine(Environment.NewLine + response);
        }
        public static void Question2()
        {
            double x, y, z; //x => ALES, y => Yabancı Dil, z => Diploma
            double _x, _y, _z, _n; //_x => ALES %55, _y => Yabancı Dil %25, _z => Diploma %20, _n => Ağırlıklı Ortalama
            Console.WriteLine("Ales puanını girin (50-100 aralığında): ");
            try
            {
                x = Convert.ToDouble(Console.ReadLine());
                if (x < 50 || x > 100)
                {
                    Console.WriteLine("Aralık dışında bir sayı girdiğiniz için program sonlandı.");
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı giriş yaptığınız için program sonlandı.");
                return;
            }
            Console.WriteLine("Yabancı Dil puanını girin (0-100 aralığında): ");
            try
            {
                y = Convert.ToDouble(Console.ReadLine());
                if (y < 0 || y > 100)
                {
                    Console.WriteLine("Aralık dışında bir sayı girdiğiniz için program sonlandı.");
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı giriş yaptığınız için program sonlandı.");
                return;
            }
            Console.WriteLine("Diploma notunu girin (0-4 aralığında): ");
            try
            {
                z = Convert.ToDouble(Console.ReadLine());
                if (z < 0 || z > 4)
                {
                    Console.WriteLine("Aralık dışında bir sayı girdiğiniz için program sonlandı.");
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı giriş yaptığınız için program sonlandı.");
                return;
            }
            _x = (x / 100) * 55;
            _y = (y / 100) * 25;
            _z = ((z * 25) / 100) * 20;
            _n = _x + _y + _z;
            Console.WriteLine($"Ales puanı: {x} \nYabancı Dil puanı: {y} \nLisans Diploma notu: {z} \nAğırlıklı Ortalama puanı: {_n}");
        }
    }
}
