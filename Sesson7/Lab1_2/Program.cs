﻿namespace Lab1_2
{
    internal class Program
    {
        /// <summary>
        /// Chương trình minh họa việc sử dụng biến, hằng số và kiểu dữ liệu
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Khai báo biến
            int id = 1;
            string name = "Xuan Truong";
            byte age = 18;
            char gender = 'V';
            //Khai báo hằng số
            const float percent = 75.50F;

            //Hiển thị giá trị các biến và hằng số
            Console.WriteLine("Student ID : {0}", id);
            Console.WriteLine("Student Name : {0}", name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Percentage : {0}", percent);
        }
    }
}