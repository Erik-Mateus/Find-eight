using System;

namespace acheOnumero8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ns = Console.ReadLine().Split(' ');

            int ns1 = int.Parse(ns[0]);
            int ns2 = int.Parse(ns[1]);

            int[,] mat = new int[ns1, ns2];

            for (int i = 0; i < ns1; i++)
            {
                string[] nums = Console.ReadLine().Split(' ');
                for (int j = 0; j < ns2; j++)
                {
                    mat[i, j] = int.Parse(nums[j]);
                }

            }

            int nEscolhido = int.Parse(Console.ReadLine());

            for (int i = 0; i < ns1; i++)
            {


                for (int j = 0; j < ns2; j++)
                {
                    if (mat[i, j] == nEscolhido)
                    {
                        Console.WriteLine("Position: " + i + "," + j);
                        if(j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if(j< ns2 - 1)
                        {
                            Console.WriteLine("Ritgth: " + mat[i, j + 1]);
                        }
                        if(i< ns1 - 1) 
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }              
                        
                    }
                    

                }

            }



        }
    }
}

