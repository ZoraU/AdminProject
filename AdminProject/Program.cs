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
            int numKey;

            do
            {
                InitialInterfaceMenu();
                Console.Write("\nEnter the key --> ");
                numKey = Convert.ToInt32(Console.ReadLine());

                if (numKey == 1) StudentInterfaceMenu(orgStudent);
                if (numKey == 2) ProfessorInterfaceMenu(orgProfessor);

            } while (numKey != 0);

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
            Console.WriteLine("\n1. Press the [ 1 ] key to add a student / view the list of students." 
                            + "\n2. Press key [ 2 ] to add a teacher / view the list of teachers."
                            + "\n3. Press [ 0 ] key to exit the program.");
        }
        static void StudentInterfaceMenu(Organization<CStudent> orgStudent)
        {
            int temporal;

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
                temporal = Convert.ToInt32(Console.ReadLine());
                StudentInterfaceLogic(temporal, orgStudent);

            } while (temporal != 0);
        }
        static void ProfessorInterfaceMenu(Organization<CProfessor> orgProfessor)
        {
            int temporal;

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
                temporal = Convert.ToInt32(Console.ReadLine());
                ProfessorInterfaceLogic(temporal, orgProfessor);
            
            } while (temporal != 0);
        }
    }
}
