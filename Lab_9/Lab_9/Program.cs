using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_9
{
    class Program
    {

        static double f_itog = 0;

        static double exp = 0.000001;

        static double steep = 0;
        static double start = 0;
        static double finish = 2;

        static double re_f (double x)
        {

            return (1 - x*x)  ;
        }


        static double analizing(double e_start, double e_end)
        {
            double itog = 0;
            int nn = 2;

            steep = (e_end - e_start) / 2;

            double f_o = (re_f(e_start + 0.5 * steep) + re_f(e_start + 1.5 * steep))*steep;

            while(true)
            {

            steep = steep / 2;

            nn *= 2;
            itog = 0;
            for (int i=0; i < nn; i++)
            {

                itog += re_f(e_start + ((double)i + 0.5) * steep);
            }
            itog *= steep;

            if (Math.Abs(itog - f_o) >= exp)
            {
                f_o = itog;
            }
            else
            {
                break;
            }

        }
            return itog;
        }



        static void Main(string[] args)
        {





            Console.WriteLine(analizing(0,2));




 
             //Thread th_1 = new Thread(analizing);
           // Thread th_2 = new Thread(analizing);
         //   Thread th_3 = new Thread(analizing);
        //    Thread th_4 = new Thread(analizing);
         //   Thread th_5 = new Thread(analizing);


            


            Console.ReadKey();
        }
    }
}
