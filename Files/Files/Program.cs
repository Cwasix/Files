using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file1 = new StreamWriter("file1.txt") ;
            StreamWriter file2 = new StreamWriter("file2.txt") ;
            string line1, line2;
            Random rnd = new Random();
            Console.WriteLine("Введите количество случайных значений");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int randomNumber1 = rnd.Next(1, 100);
                int randomNumber2 = rnd.Next(1, 100);

                file1.WriteLine(randomNumber1);
                file2.WriteLine(randomNumber2);
            }
            file1.Close();
            file2.Close();
            StreamReader read1 = new StreamReader("file1.txt") ;
            StreamReader read2 = new StreamReader("file2.txt") ;
            StreamWriter file3 = new StreamWriter("file3.txt") ; 
            while ((line1 = read1.ReadLine()) != null && (line2 = read2.ReadLine()) != null)
            {
                int value1 = Convert.ToInt32((line1));
                int value2 = Convert.ToInt32((line2));
                int sum = value1 + value2;
                file3.WriteLine(sum);
            }

        }
    }
}
