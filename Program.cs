using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasCalculatorConsoleApp
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;
            switch (op)
            {
                case "1":
                    result = num1 + num2;
                    break;
                case "2":
                    result = num1 - num2;
                    break;
                case "3":
                    result = num1 * num2;
                    break;
                case "4":
               
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
              
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            
            Console.WriteLine("Console Calculator App\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
               
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

               
                Console.Write("Inputkan Nilai Pertama: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Input Tidak Valid, Tolong masukkan Nilai yang Benar: ");
                    numInput1 = Console.ReadLine();
                }

              
                Console.Write("Inputkan Nilai Kedua: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Input Tidak Valid, Tolong masukkan Nilai yang Benar: ");
                    numInput2 = Console.ReadLine();
                }

                
                Console.WriteLine("Pilih Opsi Menu Di Bawah:");
                Console.WriteLine("\t1 - Penambahan");
                Console.WriteLine("\t2 - Pengurangan");
                Console.WriteLine("\t3 - Perkalian");
                Console.WriteLine("\t4 - Pembagian");
                Console.Write("Input Nomor Menu Di Atas: ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Maaf Menu yang Anda Pilih Tidak Tersedia.\n");
                    }
                    else Console.WriteLine("Hasilnya: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                
                Console.Write("Tekan 'n' dan Enter untuk keluar, atau tekan sembarang dan Enter untuk lanjut: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); 
            }
            return;
        }
    }

}
