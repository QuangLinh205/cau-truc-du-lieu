//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace linkedlist
//{
//    class Animal
//    {
//        public string name { get; set; }
//        public int age { get; set; }
//        public mau colot { get; set; }
//    }
//    enum mau
//    {
//        blue, red, black
//    }
//    class sortedlist3
//    {
//        static SortedList<string, Animal> convat()
//        {
//            var cv = new SortedList<string, Animal>
//            {
//                {"Dog", new Animal{name = "kiki", age = 2, colot = mau.red} },
//                {"Cat", new Animal{name = "tutu", age = 3, colot =mau.black} }
//            };
//            return cv;
//        }
//        static void xuat(SortedList<string, Animal> cvat)
//        {
//            foreach(var key in cvat.Keys)
//            {
//                Console.WriteLine(" {0}, {1}, {2}", cvat[key].name, cvat[key].age, cvat[key].colot);
//            }
//        }
//        static void Main(string[] args)
//        {
//            var a = convat();
//            xuat(a);
//            Console.ReadKey();
//        }
//    }
//}
