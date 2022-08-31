using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public partial class Program
    {
        static void StudentInterfaceLogic(int tmp, SchoolOrganization<CStudent> Stud)
        {
            if (tmp == 1)
            {
                Console.Clear();
                CStudent objStudent = new();
                objStudent.SetInfo();
                Stud.AgregarMiembro(objStudent);
            }
            if (tmp == 2)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("<------- Students List ------->");
                Console.WriteLine("-------------------------------\n");
                Stud.MostrarMiembros();
                Console.Write("\nPress any key to exit the list [...] --> ");
                Console.ReadLine();
            }
            if (tmp == 3)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("<------ Eliminate Students ------>");
                Console.WriteLine("----------------------------------\n");
                Stud.MostrarIndicesMiembros();

                Console.Write("\nEnter the number of the member to be deleted [0, 1, 2...] -->" );
                int numMember = Convert.ToInt32(Console.ReadLine());
                Stud.EliminarMiembro(numMember);
            }
        }
        static void ProfessorInterfaceLogic(int tmp, SchoolOrganization<CProfessor> Prof)
        {
            if (tmp == 1)
            {
                Console.Clear();
                CProfessor objProfessor = new();
                objProfessor.SetInfo();
                Prof.AgregarMiembro(objProfessor);
            }
            if (tmp == 2)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("<------ Professors List ------>");
                Console.WriteLine("-------------------------------\n");
                Prof.MostrarMiembros();
                Console.Write("\nPress any key to exit the list [...] --> ");
                Console.ReadLine();
            }
            if (tmp == 3)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("<------ Eliminate Professors ------>");
                Console.WriteLine("----------------------------------\n");
                Prof.MostrarIndicesMiembros();

                Console.Write("\nEnter the number of the member to be deleted [0, 1, 2...] -->");
                int numMember = Convert.ToInt32(Console.ReadLine());
                Prof.EliminarMiembro(numMember);
            }
        }
    }
}