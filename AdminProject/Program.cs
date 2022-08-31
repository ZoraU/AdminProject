using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            SchoolOrganization<CStudent> staffStudent = new SchoolOrganization<CStudent>();
            SchoolOrganization<CProfessor> staffProfessor = new SchoolOrganization<CProfessor>();
            int numKey;

            do
            {
                InitialInterface();
                Console.Write("\nEnter the key --> ");
                numKey = Convert.ToInt32(Console.ReadLine());

                if (numKey == 1) StudentInterface(staffStudent);
                if (numKey == 2) ProfessorInterface(staffProfessor);

            } while (numKey != 3);

            Console.Clear();
            Console.WriteLine("\nThank you for using our services ;)\n");

        }
        static void InitialInterface()
        {
            Console.Clear();
            var message = string.Format("!Welcome to the school staff platform!");
            Console.WriteLine(">------------------------------------<");
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(">------------------------------------<");
            Console.WriteLine("\n\n1. Press the [ 1 ] key to add a student / view the list of students." 
                            + "\n2. Press key [ 2 ] to add a teacher / view the list of teachers."
                            + "\n3. Press [ 3 ] key to exit the program.");
        }
        static void StudentInterface(SchoolOrganization<CStudent> Stud)
        {
            int tmp;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("<---- Student Interface ---->");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("\n\n1. Press the [ 1 ] key to add a new student."
                                + "\n2. Press the [ 2 ] key to view the list of students."
                                + "\n3. Press the [ 0 ] key to exit the interface.");

                Console.Write("\nEnter the key --> ");
                tmp = Convert.ToInt32(Console.ReadLine());
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

            } while (tmp != 0);
        }
        static void ProfessorInterface(SchoolOrganization<CProfessor> Prof)
        {
            int tmp;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("<--- Professor Interface --->");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("\n\n1. Press the [ 1 ] key to add a new teacher."
                                + "\n2. Press the [ 2 ] key to view the list of teachers."
                                + "\n3. Press the [ 0 ] key to exit the interface.");

                Console.Write("\nEnter the key --> ");
                tmp = Convert.ToInt32(Console.ReadLine());
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
            } while (tmp != 0);
        }
    }
}
