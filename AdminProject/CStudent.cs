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
            StringException(ref FirstName);
            Console.Write("Your Last Name: ");
            StringException(ref LastName);
            Console.Write("Your Age: ");
            NumericException(ref Age);
            Console.Write("Your Id: ");
            NumericException(ref Id);
            // Method for completing the information
            SetInfoStudent();
        }

        private void SetInfoStudent()
        {
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("<---- Complete student information ---->");
            Console.WriteLine("----------------------------------------\n");
            Console.Write("Grade currently in school: ");
            NumericException(ref _degree);
            Console.Write("Modality of study: ");
            StringException(ref _modality);
        }

        private string _modality;
        private long _degree;
    }
}
