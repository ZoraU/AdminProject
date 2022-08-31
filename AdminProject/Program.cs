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
                InitialInterfaceMenu();
                Console.Write("\nEnter the key --> ");
                numKey = Convert.ToInt32(Console.ReadLine());

                if (numKey == 1) StudentInterfaceMenu(staffStudent);
                if (numKey == 2) ProfessorInterfaceMenu(staffProfessor);

            } while (numKey != 3);

            Console.Clear();
            Console.WriteLine("\nThank you for using our services ;)\n");

        }
        static void InitialInterfaceMenu()
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
        static void StudentInterfaceMenu(SchoolOrganization<CStudent> Stud)
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
                                + "\n3. Press the [ 3 ] key to delete members."
                                + "\n4. Press the [ 0 ] key to exit the interface.");
                Console.Write("\nEnter the key --> ");
                tmp = Convert.ToInt32(Console.ReadLine());

                // Interface Logic >>>
                StudentInterfaceLogic(tmp, Stud);
            } while (tmp != 0);
        }
        static void ProfessorInterfaceMenu(SchoolOrganization<CProfessor> Prof)
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
                                + "\n3. Press the [ 3 ] key to delete members."
                                + "\n4. Press the [ 0 ] key to exit the interface.");
                Console.Write("\nEnter the key --> ");
                tmp = Convert.ToInt32(Console.ReadLine());

                // Interface Logic >>>
                ProfessorInterfaceLogic(tmp, Prof);
            } while (tmp != 0);
        }
    }
}
