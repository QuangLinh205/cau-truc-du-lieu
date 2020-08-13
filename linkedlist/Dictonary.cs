//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace linkedlist
//{
//    class Dictonary
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<int, string> a = new Dictionary<int, string>();
//            a.Add(1, "linh");
//            a.Add(2, "quang");
//            a.Add(3, "nguyen");
//            Console.WriteLine("so phan tu co trong a la {0}", a.Count);
//            Console.WriteLine("cac gia tri trong a la: ");
//            // mỗi một phần tử trong Dictonary được định nghĩa là một đối tượng có kiêu KeyValuePair<TKey, TValue>
//            foreach (KeyValuePair<int, string> b in a)
//            {
//                Console.WriteLine(" {0} --- {1}", b.Key, b.Value);
//            }
//            Console.WriteLine("kiem tra xem phan tu co key la 'mot' co ton tai khong :{0}", a.ContainsKey(1));
//            Console.WriteLine("kiem tra xem phan tu co key la 'bon' co ton tai khong :{0}", a.ContainsKey(4));

//            Console.WriteLine("kiem tra xem phan tu co value la 'linh' co ton tai khong :{0}", a.ContainsValue("linh"));
//            Console.WriteLine("kiem tra xem phan tu co value la 'tien' co ton tai khong :{0}", a.ContainsValue("tien"));
//            Console.WriteLine("truy xuat du lieu co key la 'hai': {0}", a[2]);
//            a.Remove(1);
//            Console.WriteLine("so phan tu co trong a sau khi xoa la {0}", a.Count);
//            // nếu truy xuất dữ liệu mà có key không tồn tại sẽ báo lỗi
//            //Console.WriteLine("truy xuat du lieu co key la 'bon': {0}", a["bon"]);
//            Console.ReadKey();


//        }
//    }
//}
