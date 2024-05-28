using System;

namespace Tutorial{
    class Vehicle {
        virtual public void Honk (){ // virtual agar bisa diedit di class turunan nya (override)
            Console.Write("Beeep Bep");
        }
    }
    class Car : Vehicle {
        public string color;
        private string createAt = "1980";
        string author = "budi"; // private
        public string CreateAt { // jika ingin mengubah value private
            get {return createAt ;}
            set {createAt = value ;}
        }

        public Car(string carColor = "red"){
            color = carColor;
        }

        public override void Honk(){
            Console.WriteLine("Minggir");
        }

        static void Main2(string[] args){
            Car myObject = new Car("yellow");
            Console.WriteLine(myObject.color);
        }
    }

    class Anime {
        
        // static void TakePrivate (string[] args){
        static void Main (string[] args){
            Car myObject = new Car("red");
            // Console.WriteLine(myObject.createAt); Error
            myObject.CreateAt = "2000";
            myObject.Honk();
            Console.WriteLine(myObject.CreateAt);
        }
    }

    abstract class Book { 
        public abstract string NamaBuku(); // hanya bisa diatur oleh class turunan
    }

    class Siswa : Book {
        public override string NamaBuku()
        {
            return "mas";
        }
    }

    interface Human { // seluruh isi dari class ini adalah abstract
        string Name();
        string Birth();
    }

    class Budi : Human{
        public string Name () {
            return "budi";
        }

        public string Birth () {
            return "20-1-2003";
        }
    }

    enum Levels { // class yang isi nya number yang tidak bisa dirubah
        Low, // 0
        Medium, // 1
        Hard, // 2
        Extreme = 5, // 5
        Baby, // 6
    }
}