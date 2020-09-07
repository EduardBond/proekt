using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace znak
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            FileStream f1 = new FileStream("D:\\znak.txt", FileMode.Open);
            StreamReader rd = new StreamReader(f1);
            FileStream f2 = new FileStream("D:\\znak2.txt", FileMode.Create);
            StreamWriter wr = new StreamWriter(f2);
            string rds;
            while (!rd.EndOfStream)
            {
                rds = rd.ReadLine();
                for (int i = 0; i < rds.Length; i++)
                {
                    if (rds[i] == ' ' && f == false)
                    {
                        wr.Write("? ");
                        f = true;
                    }
                    else wr.Write(rds[i]);
                }
                f = false;
                wr.WriteLine();

            }
            
            Console.ReadKey(true);
            rd.Close();
            f1.Close();
            wr.Close();
            f2.Close();
        }
    }
}
