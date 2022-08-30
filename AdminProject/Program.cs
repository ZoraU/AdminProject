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
            InitialInterface();
        }
        static void InitialInterface()
        {
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("¡Welcome to our virtual institution!");
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("1. View the list of students / Add a new student = Press the [ E ] key.");
            Console.WriteLine("2. View the list of teachers / Add a new teacher = Press the [ P ] key.");

            Console.Write("\nEnter the key --> ");
            string Key = Console.ReadLine();
            CheckCondition(Key);

        }
    }
    public partial class Program
    {
        static void StudentInterface(string Key)
        {
            Console.Clear();
            Console.WriteLine("\nYour are in Student Interface\n");

            Console.WriteLine("1. Press the [ A ] key to add a new student.");
            Console.WriteLine("2. Press the [ V ] key to view the list of students.");
            Console.WriteLine("3. Press the key [ S ] to return to the initial menu ");
            Console.Write("\nEnter the key --> \n");
        }
        static void ProfessorInterface(string Key)
        {
            Console.Clear();
            Console.WriteLine("\nYour are in Professor Interface");

            Console.WriteLine("1. Press the [ A ] key to add a new Professor.");
            Console.WriteLine("2. Press the [ V ] key to view the list of Professor.");
            Console.WriteLine("3. Press the key [ S ] to return to the initial menu ");
            Console.Write("\nEnter the key --> \n");
        }
        static void CheckCondition(string Key)
        {
            if (Key.Equals("E", StringComparison.OrdinalIgnoreCase)) StudentInterface(Key);
            else if (Key.Equals("P", StringComparison.OrdinalIgnoreCase)) ProfessorInterface(Key);
            else Console.WriteLine("Invalid key");
        }
    }
}
