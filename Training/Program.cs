using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Attempt = ");
            int numOfAttempt = Convert.ToInt32(Console.ReadLine());
            var rand = new Random();
            string[] arrCorrect = new string[numOfAttempt];
            string[] arrIncorrect = new string[numOfAttempt];
            string[] arrProblem = new string[numOfAttempt];

            for (int i = 0; i < numOfAttempt; i++)
            {
                int randNum1 = rand.Next(0, 101);
                int randNum2 = rand.Next(0, 101);
                Console.WriteLine("{0} + {1} = ", randNum1, randNum2);
                arrProblem[i] = Convert.ToString(randNum1) + " + " + Convert.ToString(randNum2) + " = ";
                int correctAns = randNum1 + randNum2;
                int ans = Convert.ToInt32(Console.ReadLine());
                if (randNum1 + randNum2 == ans)
                {
                    arrCorrect[i] = Convert.ToString(ans) + " was correct ";
                    arrIncorrect[i] = " no mistake";
                }
                else
                {
                    arrIncorrect[i] = Convert.ToString(ans) + " was mistake ";
                    arrCorrect[i] = Convert.ToString(correctAns) + " was correct";
                }
            }
            for (int i = 0; i < numOfAttempt; i++)
            {
                Console.WriteLine(arrProblem[i] + "|" + arrCorrect[i] + "|" + arrIncorrect[i]);
            }
        }
    }
}
