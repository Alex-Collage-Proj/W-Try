using System;

namespace tesk00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double NumBig=0, NumSmall=0, Sum=0, Memucha=0,checking=0,count=1;

            Console.WriteLine("Please Enter First Number");
            checking = int.Parse(Console.ReadLine());
            if(checking!=-1)
            NumBig =NumSmall=Sum=checking;
            //check number if enter

            Console.WriteLine(""+checking+ "," + NumSmall+ ","+NumBig + "," + Sum);



            while (checking != -1)
            {

                Console.WriteLine("Thank you for The Number Please Enter Another One");
                checking = int.Parse(Console.ReadLine());
                
              



                if (checking > NumBig)
                    NumBig = checking;

                if (checking < NumSmall&&checking!=-1)
                    NumSmall = checking;


                Sum = Sum+checking;
                if(checking != -1)
                    count = count + 1;
            }

            Memucha = Sum / count;

            Console.WriteLine("Your Bigest:"+NumBig);
            Console.WriteLine("Your Smallest:"+NumSmall);
            Console.WriteLine("Your Memucha:"+Memucha);
            Console.WriteLine("Thank you for Practicipet Have A Good Day");




        }
    }
}
