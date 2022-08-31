﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public class CProfessor : CPerson
    {
        public override string ToString()
        {
            string message = string.Format($"Name: {FirstName} {LastName} | "
                            + $"Field: {_fieldExperience} | "
                            + $"Experience: {_yearsExperience} years | "
                            + $"Age: {Age}");
            return message;
        }

        public override void SetInfo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("<---- Professor Information ---->");
            Console.WriteLine("---------------------------------\n");
            Console.Write("Your Name: ");
            FirstName = Console.ReadLine();
            Console.Write("Your Last Name: ");
            LastName = Console.ReadLine();
            Console.Write("Your Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your Id: ");
            Id = (int)Convert.ToInt64(Console.ReadLine());
            // Method for completing the information
            SetInfoProfessor();
        }

        private void SetInfoProfessor()
        {
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("<---- Complete professor information ---->");
            Console.WriteLine("------------------------------------------\n");
            Console.Write("Years of experience in the sector: ");
            _yearsExperience = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sector in which you work: ");
            _fieldExperience = Console.ReadLine();
        }

        private int _yearsExperience;
        private string _fieldExperience;
    }
}
