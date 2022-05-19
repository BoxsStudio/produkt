using System;
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
            for (int i = 1; i < 11; i++)
            {
                string d1 = i + ".txt";
                StreamWriter sw = new StreamWriter(d1);



            }
            Console.WriteLine("посмотреть товары 1");
            int read = Convert.ToInt32(Console.ReadLine());
            

            if(read == 1)
            {
                

                for (int i = 1; i < 11; i++)
                {
                    string dd = i + ".txt";
                    StreamReader sr = new StreamReader(dd);
                    Console.WriteLine(sr.ReadToEnd());

                    
                    
                }
                
            }
            
        }
    }
}
