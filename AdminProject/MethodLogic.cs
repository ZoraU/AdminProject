using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public partial class Program
    {
        private static void StudentInterfaceLogic(int temporal, Organization<CStudent> org)
        {
            // Nota: Si se cumple está condición se creara un nuevo objeto del tipo
            if (temporal == 1)
            {
                Console.Clear();
                CStudent objStudent = new();
                objStudent.SetInfo();
                org.AddMember(objStudent);
            }
            // Nota: Si se cumple está condición se mostrará la lista de los estudiantes agregados
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
            // Nota: Si se cumple está condición se mostrará una interfaz de eliminación por consola
            if (temporal == 3)
            {
                DeleteInterfaceLogic(org);
            }
        }

        private static void ProfessorInterfaceLogic(int temporal, Organization<CProfessor> org)
        {
            // Nota: Si se cumple está condición se creara un nuevo objeto del tipo
            if (temporal == 1)
            {
                Console.Clear();
                CProfessor objOrgessor = new();
                objOrgessor.SetInfo();
                org.AddMember(objOrgessor);
            }
            // Nota: Si se cumple está condición se mostrará la lista de los estudiantes agregados
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
            // Nota: Si se cumple está condición se mostrará una interfaz de eliminación por consola
            if (temporal == 3)
            {
                DeleteInterfaceLogic(org);
            }
        }

        // <---------------------------> // <---------------------------> // <---------------------------> //

        // Nota: Este método implementa los métodos de la clase genérica "Organization<T>" para eliminar elementos
        private static void DeleteInterfaceLogic<T>(Organization<T> org)
        {
            int numKey;
            // Nota: Llamado al header de la interfaz de eliminación
            DeleteInterface(org);
                
            do
            {
                // Nota: Menú de la interfaz de eliminación
                Console.WriteLine("\n - Press the [ 1 ] key to delete personnel."
                                + "\n - Press the [ 2 ] key to delete all personnel."
                                + "\n - Press the [ 0 ] key to exit the view.");
                
                Console.Write("\nEnter the key --> ");
                numKey = int.Parse(Console.ReadLine());
                if (numKey == 1)
                {
                    // Nota: Este método elimina la persona indicada en el indice [index...]
                    Console.Write("\nEnter the number of the member to be deleted [0, 1, 2...] --> ");
                    int numDeletePerson = int.Parse(Console.ReadLine());
                    org.RemoveMember(numDeletePerson);
                    Console.Clear();
                }
                if (numKey == 2)
                {
                    // Nota: Este método elimina a todas las personas listadas [Clear all...]
                    Console.Write("\nAre you sure to eliminate all personnel? [Y/N] --> ");
                    string deleteAllPerson = Console.ReadLine();
                    if (deleteAllPerson.Equals("Y", StringComparison.OrdinalIgnoreCase)) org.RemoveAllMembers();
                }

                DeleteInterface(org);
            } while (numKey != 0);
        }

        // Nota: Esté método se recarga cada vez que se ejecuta una acción en el método "DeleteInterfaceLogic"
        private static void DeleteInterface<T>(Organization<T> org)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("<-------- Delete Persons -------->");
            Console.WriteLine("----------------------------------\n");
            org.ShowMemberIndexes();
        }

        // Nota: Esté método capta las excepciones de la clase "Program", esto se refiere a errores que
        // pueden surgir al moverse por las interfaces "CProfessor" o "CStudent"
        private static void NumericException(ref int num)
        {
            do
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch
                {
                    num = -1;
                    Console.WriteLine("\nOpps! Invalid data type");
                    Console.Write("Try again --> ");
                }
            } while (num == -1);
        }
    }
}