﻿using System;
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
        }
    }
}