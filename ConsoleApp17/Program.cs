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
            
            
           StreamReader df = new StreamReader("LOG.txt");
            int dwe = Convert.ToInt32(df.ReadLine());
            df.Close();
            if (dwe == 1)
            {
                StreamWriter sw = new StreamWriter("1.txt");
                sw.Close();

            }
            
            
                


            
            Console.WriteLine("1 посмотреть товары  2 добавить товар 3 редачить товар 4 закончить");
            int read = Convert.ToInt32(Console.ReadLine());
            

            if(read == 1)
            {
                

                for (int i = 1; i < 1001; i++)
                {
                    string dd = i + ".txt";
                    StreamReader sr = new StreamReader(dd);
                    Console.WriteLine(sr.ReadToEnd());

                    
                    
                }
                
            }
            if (read == 2)
            {
                if (dwe > 1)
                {
                    StreamWriter fails2 = new StreamWriter(dwe +".txt");
                    fails2.Close();
                }
                Console.WriteLine("namber fails " + dwe);
                Console.WriteLine("name");
                string read1 = Console.ReadLine();
                if (dwe > 1)
                {
                    
                }
                dwe++;
                
                
                
                df.Close();

               

            }

        }
    }
}
