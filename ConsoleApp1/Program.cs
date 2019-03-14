using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            string[] stuID = new string[3];
            int[] stuScore = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please Type in Student Name : ");
                student.StuID = Console.ReadLine();
                stuID[i] = student.StuID;
                Console.Write("Please Type in Student Score : ");
                int score = int.Parse(Console.ReadLine());
                if (score > 100)
                {
                    score = 100;
                }
                else if (score < 0)
                {
                    score = 0;
                }
                student.StuScore = score;
                stuScore[i] = student.StuScore;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Student Name : " + stuID[i]);
                Console.WriteLine("Student Score:" + stuScore[i]);
                Console.ReadLine();
            }
            Console.Write("Press Any Button To Quit");
            Console.ReadKey();
        }

        class Student
        {
            public string StuID { get; set; }
            public int StuScore { get; set; }
        }
    }
}