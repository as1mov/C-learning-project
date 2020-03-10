using System;

namespace CSharpLearningProject
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i < 10)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
                                                 
            Console.ReadKey();
        }
    }
}
