using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public partial class Program
    {
        static void StudentInterfaceLogic(int temporal, Organization<CStudent> org)
        {
            if (temporal == 1)
            {
                Console.Clear();
                CStudent objStudent = new();
                objStudent.SetInfo();
                org.AddMember(objStudent);
            }
            if (temporal == 2)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("<------- Students List ------->");
                Console.WriteLine("-------------------------------");
                Console.WriteLine();
                org.ShowMembers();

                Console.Write("\nPress any key to exit the list [...] --> ");
                Console.ReadLine();
            }
            if (temporal == 3)
            {
                DeleteInterfaceLogic(org);
            }
        }

        static void ProfessorInterfaceLogic(int temporal, Organization<CProfessor> org)
        {
            if (temporal == 1)
            {
                Console.Clear();
                CProfessor objOrgessor = new();
                objOrgessor.SetInfo();
                org.AddMember(objOrgessor);
            }
            if (temporal == 2)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("<------ Professors List ------>");
                Console.WriteLine("-------------------------------");
                Console.WriteLine();
                org.ShowMembers();

                Console.Write("\nPress any key to exit the list [...] --> ");
                Console.ReadLine();
            }
            if (temporal == 3)
            {
                DeleteInterfaceLogic(org);
            }
        }

        // <---------------------------> // <---------------------------> // <---------------------------> //

        // Nota: Este método implementa los métodos de la clase genérica "Organization<T>" para eliminar elementos
        static void DeleteInterfaceLogic<T>(Organization<T> org)
        {
            int numKey;
            DeleteInterface(org);
                
            do
            {
                Console.WriteLine("\n - Press the [ 1 ] key to delete personnel."
                                + "\n - Press the [ 2 ] key to delete all personnel."
                                + "\n - Press the [ 0 ] key to exit the view.");
                
                Console.Write("\nEnter the key --> ");
                numKey = Convert.ToInt32(Console.ReadLine());
                if (numKey == 1)
                {
                    // Nota: Este método elimina la persona indicada en el indice [index...]
                    Console.Write("\nEnter the number of the member to be deleted [0, 1, 2...] --> ");
                    int numDeletePerson = Convert.ToInt32(Console.ReadLine());
                    org.RemoveMember(numDeletePerson);
                    Console.Clear();
                }
                if (numKey == 2)
                {
                    // Nota: Este método elimina a todas las personas listadas [Clear all...]
                    Console.Write("\nAre you sure to eliminate all personnel? [Y/N] --> ");
                    string deleteAllPerson = Console.ReadLine();
                    if (deleteAllPerson.Equals("Y", StringComparison.OrdinalIgnoreCase)) org.RemoveAllMembers();
                    else DeleteInterface(org);
                }

                DeleteInterface(org);
            } while (numKey != 0);
        }
        static void DeleteInterface<T>(Organization<T> org)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("<-------- Delete Persons -------->");
            Console.WriteLine("----------------------------------\n");
            org.ShowMemberIndexes();
        }
    }
}