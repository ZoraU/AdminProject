using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public partial class CStudent : CPerson
    {
        public override string ToString()
        {
            string message = string.Format($"Name: {FirstName} {LastName} | "
                            + $"Degree: °{_degree} | "
                            + $"Modality: {_modality} | "
                            + $"Age: {Age}");
            return message;
        }

        public override void SetInfo()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("<---- Student Information ---->");
            Console.WriteLine("-------------------------------\n");
            Console.Write("Your Name: ");
            FirstName = Console.ReadLine();
            Console.Write("Your Last Name: ");
            LastName = Console.ReadLine();
            Console.Write("Your Age: ");
            Age = Convert.ToInt64(Console.ReadLine());
            Console.Write("Your Id: ");
            Id = Convert.ToInt64(Console.ReadLine());
            // Method for completing the information
            SetInfoStudent();
        }

        private void SetInfoStudent()
        {
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("<---- Complete student information ---->");
            Console.WriteLine("----------------------------------------\n");
            Console.Write("Grade currently in school: ");
            _degree = Convert.ToInt64(Console.ReadLine());
            Console.Write("Modality of study: ");
            _modality = Console.ReadLine();
        }

        private string _modality;
        private long _degree;
    }
}
