using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public struct SEstudiante
    {
        public void AddEstudiante()
        {
            Console.Write("First Name: ");
            this.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            this.LastName = Console.ReadLine();
            Console.Write("Current Degree: ");
            this.Degree = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age: ");
            this.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Id: ");
            this.Id = (int)Convert.ToInt64(Console.ReadLine());
        }

        public void getInfoEstudiante()
        {
            Console.WriteLine($"Student: {FirstName} {LastName} " + $"Degree: °{Degree} " + $"Age: {Age} " + $"Id: {Id}");
        }

        public void AddRatings()
        {
            for (int i = 0; i < Ratings.Length; i ++)
            {
                Console.Write($"Set a No. {i + 1} rating: ");
                Ratings[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }
        }

        string FirstName;
        string LastName;
        int Degree;
        int Age;
        int Id;
        double[] Ratings = new double[3];

        public SEstudiante()
        {
        }
    }
}
