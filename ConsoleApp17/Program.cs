﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReaderLog = new StreamReader("LOG.txt");
            int countFiles = Convert.ToInt32(streamReaderLog.ReadLine());
            streamReaderLog.Close();

            Console.WriteLine("1 посмотреть товары  2 добавить товар 3 редачить товар 4 закончить");
            int choose = Convert.ToInt32(Console.ReadLine());


            if (choose == 1)
            {
                for (int i = 1; i < countFiles; i++)
                {
                    string productFileName = i + ".txt";
                    
                    StreamReader streamReaderProduct = new StreamReader(productFileName);
                    
                    Console.WriteLine(streamReaderProduct.ReadToEnd());

                    streamReaderProduct.Close();
                }
            }
            //if (choose == 2)
            //{ 
            //    StreamWriter fails2 = new StreamWriter(countFiles + ".txt");
            //    fails2.Close();
                
            //    Console.WriteLine("namber fails " + countFiles);
            //    Console.WriteLine("name");
            //    string read1 = Console.ReadLine();

            //    countFiles++;



            //    streamReaderLog.Close();



            //}

        }
    }
}
