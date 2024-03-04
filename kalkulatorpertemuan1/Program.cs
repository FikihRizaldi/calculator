using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace kalkulatorpertemuan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator Sederhana");
            Console.WriteLine("Pilih Operasi");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("Masukkan menu (1-4): ");

            int pilihan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Angka Pertama: ");
            double angka1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Angka Kedua: ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    hasil = angka1 + angka2;
                    Console.WriteLine("Hasil Penjumlahan : "  + hasil);
            }
        }
        /*{
            Console.Title = "Aplikasi Kalkulator";
            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();                

            Console.WriteLine("Hasil Penambahan " + a + "+" + b + "=" + penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0}  * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0}  / {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }*/
    }
}