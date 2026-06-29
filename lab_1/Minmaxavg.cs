//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lab_1
//{
//    internal class Minmaxavg
//    {
//        static void Main()
//        {
//            int[] marks = new int[5];

//            for (int i = 0; i < 5; i++)
//            {
//                Console.Write("Enter Marks: ");
//                marks[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            int min = marks[0], max = marks[0], sum = 0;

//            foreach (int m in marks)
//            {
//                if (m < min) min = m;
//                if (m > max) max = m;
//                sum += m;
//            }

//            Console.WriteLine("Minimum = " + min);
//            Console.WriteLine("Maximum = " + max);
//            Console.WriteLine("Average = " + (sum / 5.0));
//        }
//    }
//}
