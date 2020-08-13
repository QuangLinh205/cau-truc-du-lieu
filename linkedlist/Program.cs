//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;

//namespace linhkedlist
//{
//    class Page
//    {
//        public int Number { get; set; }
//        public string Content { get; set; }
//    }
//    class Program
//    {
//        // khởi tạo phương thức Open có kiểu trả về là kiểu LinkedList<page> với 2 tham số truyền vào là (string file, int charPerPage)
//        static LinkedList<Page> Open(string file, int charPerPage)
//        {

//            LinkedList<Page> pages = new LinkedList<Page>();
//            var content = File.ReadAllText(file); // ReadAllText() đọc toàn bộ ký tự và 
//            var p = 0;
//            for (p = 0; p < content.Length / charPerPage; p++) 
//            {
//                var pageContent = content.Substring(charPerPage * p, charPerPage);
//                pages.AddLast(new Page { Number = p + 1, Content = pageContent });
//            }
//            pages.AddLast(new Page { Number = p + 1, Content = content.Substring(charPerPage * p) });
//            return pages;
//        }
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.Unicode;

//            var pages = Open("Chú lính chì dũng cảm.txt", 1000);

//            var current = pages.First;
//            while (current != null)
//            {
//                Console.Clear();
//                Console.WriteLine($"- page {current.Value.Number} -\r\n");
//                Console.WriteLine(current.Value.Content);
//                Console.WriteLine("\r\n< Previous [P] | [N] Next >");
//                switch (Console.ReadKey(true).Key)
//                {
//                    // consoleKey.A tương đương với ấn phím A từ bàn phím
//                    case ConsoleKey.A:
//                        if (current.Next != null)
//                        {
//                            current = current.Next; // tương đương với (pages.First).next => hiển thị ra 1000 từ tiếp theo 
//                        }
//                        break;
//                    // ConsoleKey.P tương đương với nhấn phím P từ bàn phím
//                    case ConsoleKey.P:
//                        if (current.Previous != null)
//                        {
//                            current = current.Previous; //tương đương với (pages.First).Previous => hiển thị ra 1000 từ sau đó
//                        }
//                        break;
//                    default: return;
//                }
//            }
//        }
//    }
//}