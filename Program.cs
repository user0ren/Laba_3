using System;
using number_of_base;

namespace Calculation_of_the_number_of_base
{
    class Program
    {
        static void Main()
        {


            Console.Write("Площадь района обслуживания: ");
            double service_area = Convert.ToDouble(Console.ReadLine()); //Площадь района обслуживания
            Console.WriteLine();

            Console.WriteLine("Коэффициенты застройки:");
            Console.WriteLine("  Плотная городская застройка К=1,21");
            Console.WriteLine("  Средняя городская застройка (малые города, новые жилые комплексы) К = 0,9");
            Console.WriteLine("  Сельская застройка К = 0,47");

            Console.Write("Коэффициент застройки: ");
            double building_rate = Convert.ToDouble(Console.ReadLine()); //Коэффициент застройки
            Console.WriteLine();


            Console.Write("Площадь покрытия базовой станции: ");
            double station_coverage_area = Convert.ToDouble(Console.ReadLine()); //Площадь покрытия базовой станции
            Console.WriteLine();


            double d1 = 0;
            double d2 = 0;
            double d3 = 0;


            while (true)
            {
                Console.WriteLine("D1, D2, D3 - диаметры 3 - х любых базовых станций с разной частотой, в порядке убывания");
                Console.Write("D1 - наибольший диаметр: ");
                d1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("D2: ");
                d2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("D3 - наименьший диаметр.: ");
                d3 = Convert.ToDouble(Console.ReadLine());

                if (d1 < d2 || d2 < d3)
                {
                    Console.WriteLine("Данные не соответствуют требованиям");
                    Console.WriteLine();
                    continue;
                }



                Console.WriteLine("D1 = " + d1 + " D2 = " + d2 + " D3 = " + d3);
                Console.WriteLine("Потвердите нажатием Enter");

                string tru = Console.ReadLine();
                if (tru == "")
                    break;
                else
                    Console.WriteLine();
            }

            Class1 myClass = new Class1();
            int i = myClass.number_of_base(service_area, building_rate, station_coverage_area, d1, d2, d3);
            Console.WriteLine(i);

        }
    }
}