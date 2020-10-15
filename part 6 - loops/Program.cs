using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_6___loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompter(); //(does not work)
            passing();
            randomnum();
            sum();


        }
          static void prompter()
        {

            int min;
            int max;
            int number;



            Console.WriteLine("Please enter a minimum value...");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a maximum value...");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number bigger then min and less then max then push enter key...");
            number = Convert.ToInt32(Console.ReadLine());


            while (number > max && number < min)
                {
                    Console.WriteLine("Please try again, enter a number bigger then the min and less then the max.");

                }


            Console.Write("Perfect!!!");

            Console.ReadLine();
          }
        static void passing()
        {
            int total;
            int score;
            int highscore = 0;
            


            Console.WriteLine("Please enter # of scores");
            total = Convert.ToInt32(Console.ReadLine());
            for (int r = 0; r < total; r++)
            {
                Console.WriteLine("Enter a score...");
                score = Convert.ToInt32(Console.ReadLine());
                if (score >= 70)
                    highscore = highscore + 1;
                Console.WriteLine($"scores over 70 is {highscore}");


            }

            Console.ReadLine();

        }
        static void randomnum()
        {
            Random numgenerator = new Random();


            int min;
            int max;
            int random;

            Console.WriteLine("Please enter a minimum value");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a maximum value");
            max = Convert.ToInt32(Console.ReadLine());
            for (int r = 1; r < 25; r++)
            {
                random = numgenerator.Next(min, max);
                Console.WriteLine(random);
            }

            Console.ReadLine();
        }
        static void sum()
        {
            int num;
            int sum = 0;


            Console.WriteLine("Please enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("Please enter a bigger number then 0");
            }
            for (int r = 1; r <= num; r += 2)
            {
                sum += r;
            }
            if (num >= 1)
            {
                Console.WriteLine(sum);
            }

            Console.ReadLine();
        }










                
        
            


            







                
                   
                   

                

            









































































        
    }
}
