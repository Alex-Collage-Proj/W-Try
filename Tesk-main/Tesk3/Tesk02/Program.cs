using System;

namespace Tesk02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleaste Enter Your Number");
            
            int a = 5,trio=0,b=0,d,start=1;
            a=int.Parse( Console.ReadLine());
            b = a-(a-1);
            d = a;
           
           
            while (a != 0)
            {

                while (trio != b)
                {

                    while (d != -1)
                    {
                        Console.Write(' ');
                        d = d - 1;
                    }

                    //התחלה ובסוף
                    
                        Console.Write("*");
                   

                    trio = trio + 1;
                    d = a - 1;
                    




                    //if (d == 0)
                    //{
                    //    d = a;
                    //    while (d != 0)
                    //    {
                    //        Console.Write(" ");
                    //        d = d - 1;
                    //    }

                    //}
                }
                b++;
                trio = 0;
                Console.WriteLine("");
                a = a - 1;
                start =start + 1;
            }


        }
    }
}
