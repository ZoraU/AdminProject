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
            Organization<CStudent> orgStudent = new Organization<CStudent>();
            Organization<CProfessor> orgProfessor = new Organization<CProfessor>();
            int numKey = -1;

            do
            {
                InitialInterfaceMenu();
                Console.Write("\nEnter the key --> ");
                NumericException(ref numKey);

                if (numKey == 1) StudentInterfaceMenu(orgStudent);
                if (numKey == 2) ProfessorInterfaceMenu(orgProfessor);

            } while (numKey != 0);

            Console.Clear();
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("Thank you for using our services ;)");
            Console.WriteLine("-----------------------------------\n");

        }
        private static void InitialInterfaceMenu()
        {
            Console.Clear();
            var message = string.Format("!Welcome to the school staff platform!");
            Console.WriteLine(">------------------------------------<");
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(">------------------------------------<");
            Console.WriteLine("\n1. Press the [ 1 ] key to add a student / view the list of students." 
                            + "\n2. Press key [ 2 ] to add a teacher / view the list of teachers."
                            + "\n3. Press [ 0 ] key to exit the program.");
        }
        private static void StudentInterfaceMenu(Organization<CStudent> orgStudent)
        {
            int temporal = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("<---- Student Interface ---->");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("\n1. Press the [ 1 ] key to add a new student."
                                + "\n2. Press the [ 2 ] key to view the list of students."
                                + "\n3. Press the [ 3 ] key to delete members."
                                + "\n4. Press the [ 0 ] key to exit the interface.");

                // <---- Interface Logic ---->
                Console.Write("\nEnter the key --> ");
                NumericException(ref temporal);
                StudentInterfaceLogic(temporal, orgStudent);

            } while (temporal != 0);
        }
        private static void ProfessorInterfaceMenu(Organization<CProfessor> orgProfessor)
        {
            int temporal = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("<--- Professor Interface --->");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("\n1. Press the [ 1 ] key to add a new teacher."
                                + "\n2. Press the [ 2 ] key to view the list of teachers."
                                + "\n3. Press the [ 3 ] key to delete members."
                                + "\n4. Press the [ 0 ] key to exit the interface.");
                
                // <---- Interface Logic ---->
                Console.Write("\nEnter the key --> ");
                NumericException(ref temporal);
                ProfessorInterfaceLogic(temporal, orgProfessor);
            
            } while (temporal != 0);
        }
    }
}
