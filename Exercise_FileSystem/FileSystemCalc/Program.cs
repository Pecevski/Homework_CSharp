using System;
using System.IO;

namespace FileSystemCalc
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            int result;
            return result = num1 + num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input secon number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1, num2, Sum(num1, num2));

            string pathFolder = @"..\..\..\";
            string folderCreate = pathFolder +  @"\Exercise";

            if (!Directory.Exists(folderCreate))
            {
                Directory.CreateDirectory(folderCreate);
            }

            string newFile = Path.Combine(folderCreate, "Calculation.txt");
            
            using (StreamWriter sw = new StreamWriter(newFile, true))
            {
                sw.WriteLine("{0} + {1} = {2}", num1, num2, Sum(num1, num2));
                sw.WriteLine(DateTime.Now);
            }

            Console.ReadLine();
        }
    }
}
