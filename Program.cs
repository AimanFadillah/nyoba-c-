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

            // Math
                Math.Max(5,10); // 10
                Math.Min(5,10); // 5
                Math.Sqrt(64);  // 8
                Math.Abs(-4.7); // Always positif
                Math.Round(9.99); // 10
            
            // Strings
                string txt = "Hai";
                txt.ToUpper() ; // HAI
                txt.ToLower() ; // hai

            // Interpolation
                string firstname = "Jhon";
                string lastname = "Doe";
                string name = $"My full name is {firstname} {lastname}";
            
            // Access Strings
                string myString = "Hello Word";
                Console.WriteLine(myString[0]); // "H"
                Console.WriteLine(myString[1]); // "e"
                Console.WriteLine(myString.IndexOf("e")); // 1
                Console.WriteLine(myString.Substring(7)); // Word
        }
    }
}