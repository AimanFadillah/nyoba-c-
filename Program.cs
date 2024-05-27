using System;

namespace HelloWord{
    class Program{
        static void Main (String[] args){
            Console.WriteLine("Hello Word"); // Console.log di C#

            // Variabel
                int angka = 1;
                double angka2 = 19.22;
                char huruf = 'A';
                bool type = true;
                string kalimat = "Hello";

            // Const (Tidak boleh dirubah)
                const int angka3 = 1;

            // Multiple Variable
                int int1 = 1,int2 = 2,int3 = 3;

            // Casting
                int myInt = 10;
                double myDouble = 9.78;
                bool myBool = true;

                Convert.ToString(myInt);
                Convert.ToDouble(myInt);
                Convert.ToInt32(myDouble); // to Int
                Convert.ToString(myBool);
            
            // User Input
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine() ?? "Kosong";
                Console.WriteLine("Your name " + username);

        }
    }
}