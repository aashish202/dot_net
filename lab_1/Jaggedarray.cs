//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lab_1
//{
//    internal class Jaggedarray
//    {
//        static void Main()
//        {
//            string[][] books = new string[3][];

//            for (int i = 0; i < 3; i++)
//            {
//                books[i] = new string[3];

//                Console.Write("Title: ");
//                books[i][0] = Console.ReadLine();

//                Console.Write("Author: ");
//                books[i][1] = Console.ReadLine();

//                Console.Write("Year: ");
//                books[i][2] = Console.ReadLine();
//            }

//            Console.WriteLine("\nBook Details");

//            for (int i = 0; i < 3; i++)
//            {
//                Console.WriteLine(books[i][0] + " | " +
//                                  books[i][1] + " | " +
//                                  books[i][2]);
//            }
//        }
//        }
//}
