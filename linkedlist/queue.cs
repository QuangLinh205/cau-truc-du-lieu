//using System;
//using System.Collections;
//using System.Collections.Generic;
//namespace linkedlist
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            //Queue myQueue = new Queue();
//            //myQueue.Enqueue("nguyen");
//            //myQueue.Enqueue("quang");
//            //myQueue.Enqueue("linh");
//            //Console.WriteLine("so phan tu trong myQueue la {0}:", myQueue.Count);
//            //Console.WriteLine("kiem tra xem 'linh' co ton tai trong myQueue khong {0}", myQueue.Contains("linh"));
//            //Console.WriteLine("kiem tra xem 'quang linh' co ton tai trong myQueue khong {0}", myQueue.Contains("quang linh"));
//            //Console.WriteLine("tra ve gia tri them vao dau tien va khong xoa gia tri do {0}", myQueue.Peek());
//            //Console.WriteLine("so phan tu trong myQueue la {0}:", myQueue.Count);
//            //Console.WriteLine("kiem tra xem 'nguyen' co ton tai trong myQueue khong {0}", myQueue.Contains("nguyen"));
//            //Console.WriteLine("tra ve gia tri them vao dau tien va xoaluon gia tri do {0}", myQueue.Dequeue());
//            //Console.WriteLine("so phan tu trong myQueue la {0}:", myQueue.Count);
//            //Console.WriteLine("kiem tra xem 'nguyen' co ton tai trong myQueue khong {0}", myQueue.Contains("nguyen"));
//            // In ra màn hình giá trị Value trong 1 Key không tồn tại.
//            // Tạo một Hashtable đơn giản với 3 phần tử
//            Hashtable hash = new Hashtable();
//            hash.Add(1, "Kteam");
//            hash.Add("H", "HowKteam");
//            hash.Add("FE", "Free Education");
//            hash.Add(3, "êrerer");
//            foreach (DictionaryEntry item in hash)
//            {
//                Console.WriteLine(item.Key + "\t" + item.Value);
//            }

//            Console.WriteLine(hash[3]);

//            // Để chắc chắn là null ta thử kiểm tra bằng điều kiện if.
//            if (hash["VT"] == null)
//            {
//                Console.WriteLine("Key 'VT' is not exists");
//            }

//            // Thử in ra số phần tử ban đầu của Hashtable
//            Console.WriteLine("\nCount: " + hash.Count);
//            foreach (DictionaryEntry item in hash)
//            {
//                Console.WriteLine(item.Key + "\t" + item.Value);
//            }

//            // thực hiện gán giá trị cho 1 Key không tồn tại.
//            hash["Kt"] = "Kter";

//            // thực hiện in lại số phần tử của Hashtable để thấy sự thay đổi.
//            Console.WriteLine("\nCount: " + hash.Count);
//            foreach (DictionaryEntry item in hash)
//            {
//                Console.WriteLine(item.Key + "\t" + item.Value);
//            }

//        }
//    }
//}