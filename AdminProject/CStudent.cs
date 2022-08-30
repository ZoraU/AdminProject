using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public class CStudent : CPerson
    {
        public override void GetInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName} | "
                            + $"Degree: °{_degree} | "
                            + $"Modality: {_modality} | "
                            + $"Age: {Age}");
        }

        public override void SetInfo()
        {
            Console.WriteLine("\n<-- Student Information -->");
            Console.Write("Your Name: ");
            FirstName = Console.ReadLine();
            Console.Write("Your Last Name: ");
            LastName = Console.ReadLine();
            Console.Write("Your Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your Id: ");
            Id = (int)Convert.ToInt64(Console.ReadLine());
            // Method for completing the information
            SetInfoStudent();
        }

        private void SetInfoStudent()
        { 
            Console.WriteLine("\n<-- Complete student information -->");
            Console.Write("Grade currently in school: ");
            _degree = Convert.ToInt32(Console.ReadLine());
            Console.Write("Modality of study: ");
            _modality = Console.ReadLine();
        }

        private string _modality;
        private int _degree;
    }
}
