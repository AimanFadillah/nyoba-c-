using System;

namespace Tutorial{
    class Program{
        static void Print(string input = "Hai"){
            Console.WriteLine(input);
        }

        static int Tambah(int angka1,int angka2){
            return angka1 + angka2;
        }

        static double Tambah(double angka1,double angka2){
            return angka1 + angka2;
        }

        static void Main (String[] args){
            int penjumlahanInt = Tambah(1,5);
            double penjumlahanDouble = Tambah(1.6,5.4);
            Print(Convert.ToString(penjumlahanInt));
            Print(Convert.ToString(penjumlahanDouble));
        }
    }
}