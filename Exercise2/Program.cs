using System;
namespace Bubble_sort
{
    class Program
    {

        //Deklarasi array int dengan ukuran 68
        private int[] a = new int[68];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array 
        private int n;

        //Fungsi /method untuk menerima masukan 

        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimppan pada array 
            while (true)
            {
                Console.WriteLine("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 92)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 92 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("_____________________");
            Console.WriteLine("Masukkan elemen Array");
            Console.WriteLine("_____________________");

            // Pengguna memasukkan elemen pada array
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("<" + (j + 1) + ">");
                string s1 = Console.ReadLine();
                a[j] = Int32.Parse(s1);
            }
        }
        public void display()
            {
            //Menampilkan array yang tersusun 
            Console.WriteLine("________________________________");
            Console.WriteLine(" Element array yang teleh tersusun ");
            Console.WriteLine("________________________________");
            for (int ah = 0; ah < n; ah++)
            {
                Console.WriteLine(a[ah]);
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}







