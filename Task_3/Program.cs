using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static readonly List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher(){Id = 1, Name = "John Smith"},
            new Teacher(){Id = 2, Name = "Lara Gilbert"},
            new Teacher(){Id = 3, Name = "Johanna Kabir"},
            new Teacher(){Id = 4, Name = "Danniel Robertson"},
            new Teacher(){Id = 5, Name = "Larry Cooper"}
        };

        static readonly List<Course> courses = new List<Course>()
        {
            new Course(){Id = 0, Name = "English Grammar"},
            new Course(){Id = 1, Name = "Mathematics"},
            new Course(){Id = 2, Name = "Physics"},
            new Course(){Id = 3, Name = "Chemistry"},
            new Course(){Id = 4, Name = "Biology"}
        };


        static void Main(string[] args)
        {
            int[,] routines = new int[4, 3];

            var input = Intro();

            if (input == "C")
            {
                for (int i = 0; i < teachers.Count; i++)
                {
                    Console.WriteLine(courses[i].Name + "," + teachers[i].Name);
                }
            }

            if (input == "A")
            {
                var count = 1;
                foreach (var item in courses)
                {
                    Console.WriteLine(count + ". " + item.Name);
                    count++;
                }

                for (int j = 0; j < 4; j++)
                {
                    var t = Console.ReadLine().Split(' ');

                    for (int k = 0; k < 3; k++)
                    {
                        routines[j, k] = Convert.ToInt32(t[k]);
                    }
                }
                input = Intro();
            }

            if (input == "B")
            {
                for (int i = 0; i < 4; i++)
                {
                    if (courses[routines[i, 2]].Id == routines[i, 2])
                    {
                         var courseName = courses[routines[i, 2]].Name;
                        Console.WriteLine(routines[i, 0] + " " + routines[i, 1] + " " + courseName);
                    }
                }
                Console.ReadKey();
            }
        }

        static string Intro()
        {
            Console.WriteLine("A. Create Routin \nB. Show Routine \nC. List Courses with Teachers Name");
            var inputsLine = Console.ReadLine();
            return inputsLine;
        }

    }
}
