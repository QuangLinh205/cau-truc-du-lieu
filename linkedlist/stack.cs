//using System;
//using System.Collections.Generic;
//using System.Collections;

//namespace P01_CustomStack
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Tạo 1 Stack rỗng
//            Stack MyStack4 = new Stack();

//            // Thực hiện thêm vài phần tử vào Stack thông qua hàm Push.
//            MyStack4.Push("Education");
//            MyStack4.Push("Free");
//            MyStack4.Push(22);
//            //đếm số lượng phần tử trong stack
//            Console.WriteLine(" so phan tu hien tai cua stack: {0}", MyStack4.Count);

//            Console.WriteLine(" phan tu dau tien cua stack: {0}", MyStack4.Peek());

//            Console.WriteLine(" so phan tu cua stack sau khi dung lenh peek(): {0}", MyStack4.Count);

//            //Console.WriteLine(" dua ra va xoa gia tri cuoi cung: {0}", MyStack4.Pop());

//            Console.WriteLine(" so phan tu cua stack sau khi dung pop pop() là : {0}", MyStack4.Count);

//            Console.WriteLine("kiem tra xem Free co ton tai khong:  {0}", MyStack4.Contains("Free"));

//            Console.WriteLine("kiem tra xem HowKteam co ton tai khong: {0}", MyStack4.Contains("HowKteam"));

//            for (int i = 0; i < MyStack4.Count; i++)
//            {
//                Console.WriteLine(MyStack4.Pop());
//            }

//        }
//    }
//}
