using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Task 1
            //string text = "Onur Rehimli 703";
            //Console.WriteLine(text.IsContainsDigit());
            //string text2 = "aZerBAYcan";
            //Console.WriteLine(text2.ToCapitalize());
            //string text3 = "Web Developer";
            //foreach (var item in text3.GetValueIndexes('e'))
            //{
            //    Console.WriteLine(item);
            //}
            //int n = 703;
            //Console.WriteLine(n.IsEven());
            //Console.WriteLine(n.IsOdd());
            // Task 2
            Console.WriteLine("Full Name :");
            string fullName = Console.ReadLine();
            while (!Student.ChechFullName(fullName))
            {
                Console.WriteLine("(Warning!) Full Name :");
                fullName = Console.ReadLine();
            }

            Console.WriteLine("Group No :");
            string groupNo = Console.ReadLine();
            while (!Student.ChechFullName(fullName))
            {
                Console.WriteLine("(Warning!) Group No :");
                groupNo = Console.ReadLine();
            }

            Console.WriteLine("Age :");
            int age = Convert.ToInt32(Console.ReadLine());

            Student std = new Student(fullName, groupNo, age);

        }
    }
}
