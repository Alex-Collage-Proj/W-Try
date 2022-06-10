using System;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num=0,kef=1,checking=0,checking7=1,v7=7;

            while(num!=10000)
            {
              //  while(checking7!>8)
               // {
                    Console.WriteLine(num);
                    if(checking7<v7)
                      num =num+ 1;

                    if(checking7==7)
                    {
                           kef = kef * 10;
                           num = 10 * kef;
                           checking7 = 0;
                    
                    }
                    checking7 = checking7 + 1;

                    

              //  }
               // checking = checking + 1;


            }



        }
    }
}
