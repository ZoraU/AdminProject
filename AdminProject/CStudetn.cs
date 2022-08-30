using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public class CStudetn : CPerson
    {
        public override void GetInfo()
        {
            
        }

        public override void SetInfo()
        {
            Console.WriteLine("<-- Personal Information -->");
            Console.Write("Your Name: ");
            FirstName = Console.ReadLine();
            Console.Write("Your Last Name: ");
            LastName = Console.ReadLine();
            Console.Write("Your Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Id: ");
            Id = (int)Convert.ToInt64(Console.ReadLine());

            SetInfoStudent();
        }

        public void SetInfoStudent()
        {
            Console.WriteLine("<-- Complete student information -->");
            Console.Write("Grade currently in school: ");
            degree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Modality of study: ");
            modality = Console.ReadLine();
        }

        private string modality;
        private int degree;
    }
}
