using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    public class Logic
    {
        public static string Count(double setTable)
        {
            string outMessage = "";

            for (int i = 1; i < 10; i++)
            {
                if ((setTable <= 9) && (setTable >= 1))
                {
                    var countTable = i * setTable;
                    outMessage = outMessage  + i + " * " + setTable + " = " + countTable+ "\n";
                }
                else
                {
                    outMessage = "Введено неверное число, перезапустите программу и повторите попытку";
                }
               


            }
            return outMessage;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, по которому надо построить таблицу умножения-");

            double setTable = double.Parse(Console.ReadLine());

            var outMessage = Logic.Count(setTable);
            Console.WriteLine(outMessage);


        }
    }
}



