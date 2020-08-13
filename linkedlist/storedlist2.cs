//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Collections;

//namespace linkedlist
//{
//    class car
//    {
//        public string Name { get; set; }
//        public int Price { get; set; }
//        public color Mau { get; set; }
//    }
//    enum color
//    {
//        xanh, den, tim, vang
//    }
//    class storedlist2
//    {
//        static SortedList<int, car> oto()
//        {
//            var xe4banh = new SortedList<int, car>
//            {
//                {1, new car{Name = "mec", Price = 1000, Mau = color.xanh } },
//                {2, new car{Name = "L", Price = 2000, Mau = color.den} }
//            };
//            return xe4banh;
//        }

//        static void print(SortedList<int, car> xe)
//        {
//            Console.WriteLine("in ra");
//            foreach (var i in xe.Keys)
//            {
//                Console.WriteLine(" {0}, {1}, {2}",xe[i].Name, xe[i].Price, xe[i].Mau);
//            }
//        }
//        static void Main(string[] args)
//        {
//            SortedList<int, car> kq = oto();
//            print(kq);
//            Console.WriteLine("truy xuat du lieu qua key 'duc' {0}: ",kq[1].Name);
//        }
//    }
//}
