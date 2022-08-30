using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            CStudetn oStudent = new CStudetn();
            CProfessor oProfessor = new CProfessor();

            oStudent.SetInfo();
            oProfessor.SetInfo();
            Console.WriteLine();
            oStudent.GetInfo();
            oProfessor.GetInfo();
        }
    }
}
