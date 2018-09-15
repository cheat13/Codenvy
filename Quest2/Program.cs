using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input n : ");
                double n = int.Parse(Console.ReadLine());

                double middle;
                double[] numbers;
                int round;

                if (n % 2 == 1)
                {
                    double a = (n - 1) / 2;
                    double b = (n + 1) / 2;
                    Console.WriteLine("Numbers: {0}, {1}", a, b);
                }
                else
                {
                    for (int i = 3; i <= n / 2; i++)
                    {
                        if (i % 2 == 1)
                        {
                            if (n % i == 0)
                            {
                                numbers = new double[i];
                                middle = n / i;
                                round = numbers.Length / 2;

                                numbers[round] = middle;

                                for (int j = 1; j <= round; j++)
                                {
                                    numbers[round - j] = numbers[round] - j;
                                    numbers[round + j] = numbers[round] + j;
                                }

                                Console.Write("Number: " + numbers[0]);

                                for (int k = 1; k < numbers.Length; k++)
                                {
                                    Console.Write(", "+numbers[k]);
                                }

                                Console.WriteLine();

                                break;
                            }
                        }
                        else
                        {
                            if (n % i == i / 2)
                            {
                                numbers = new double[i];
                                middle = n / i;
                                round = numbers.Length / 2;
                                
                                numbers[i / 2 - 1] = Math.Floor(middle);
                                numbers[i / 2] = Math.Ceiling(middle);
                                
                                for (int j = 1; j < round; j++)
                                {
                                    numbers[(i / 2 - 1) - j] = numbers[i / 2 - 1] - j;
                                    numbers[(i / 2) + j] = numbers[i / 2] + j;
                                }

                                Console.Write("Number: " + numbers[0]);

                                for (int k = 1; k < numbers.Length; k++)
                                {
                                    Console.Write(", " + numbers[k]);
                                }

                                Console.WriteLine();

                                break;
                            }
                            else if (i == n / 2)
                            {
                                Console.WriteLine("No answer!");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
