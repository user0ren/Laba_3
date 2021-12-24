using System;

namespace number_of_base
{
    public class Class1
    {
        public int number_of_base(double s, double K, double S, double d1, double d2, double d3)
        {

            if (s > 0 & K > 0 & S > 0 & d1 >= 0 & d2 >= 0 & d3 >= 0)
            {
                const double Pi = Math.PI;

                double R0 = Math.Sqrt(s / Pi);

                double R = Math.Sqrt(S / Pi);

                double L = K * Math.Pow(R0 / R, 2);

                if (d1 < d2)
                {
                    if (d2 < d3)
                        d2 = d3;
                }


                double C = Math.Pow(d1, 2.5) + Math.Pow(d2, 1.5) + Math.Pow(d3, 0.5);

                int n = Convert.ToInt32(L / C);

                return (n);
            }

            return (-1);


        }
    }
}
