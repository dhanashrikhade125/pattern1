using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //        for (int i = 1; i <= 4; i++)
            //        {
            //            for (int j = 1; j <= 5; j++) // column
            //            {
            //                Console.Write("*");
            //            }
            //            Console.WriteLine();
            //        }


            // o/p =
            // *****
            //*****
            //*****
            //*****


            //        for(int i=1; i<=5;i++)
            //        { 
            //            for(int j=1;j<=5-i;j++)
            //            {
            //                Console.Write(" ");
            //            }
            //           for(int k=1;k<=(2* i-1);k++)
            //            {
            //                Console.Write("*");
            //            }
            //           Console.WriteLine(); ;
            //        }
            //        Console.WriteLine("End of Program");


            // o/p= 
            //    *
            //   ***
            //  *****
            // *******
            //*********
            //End of Program



            //int i, j;
            //for (i = 0; i < 6; i++)
            //{

            //    for (j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    } 
            //    Console.WriteLine();
            //}

            //o/p = 
            //*
            //**
            //***
            //****
            //*****
            //******

            //int i, j;
            //for (i = 0; i < 5; i++)
            //{
            //    for (j = 2 * (5 - i); j >= 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //        for (j = 0; j <= i; j++)
            //        {
            //            Console.Write("* ");
            //        }
            //        Console.WriteLine();
            // }


            //o/p
            //     *
            //    **
            //   ***
            //  ****
            // *****

            //int rows = 5;
            ////inner loop  
            //for (int i = rows - 1; i >= 0; i--)
            //{
            //    //outer loop  
            //    for (int j = 0; j <= i; j++)
            //    {
            //        //prints star and space  
            //        Console.Write("*" + " ");
            //    }
            //    //throws the cursor in the next line after printing each line  
            //    Console.WriteLine();
            //}

            //o/p
            //*****
            //****
            //***
            //**
            //*

            //for (int i = 0; i <= 5; i++)
            //{
            //    //outer loop  
            //    for (int j = 1; j <= 5 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            //o/p
            //    *
            //   **
            //  ***
            // ****
            //*****
            //******
        }
    }
}


