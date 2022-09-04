using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdminProject
{
    public abstract partial class CPerson
    {
        protected string FirstName;
        protected string LastName;
        protected long Id;
        protected long Age;

        public abstract void SetInfo();
    }

    // Nota: en esta sección se captarán los errores de datos al llenar los campos de información

    public abstract partial class CPerson
    {
        protected static void NumericException(ref long num)
        {
            do
            {
                try
                {
                    num = long.Parse(Console.ReadLine());
                }
                catch
                {
                    num = -1;
                    Console.WriteLine("\nOpps! Invalid data type");
                    Console.Write("Try again --> ");
                }
            } while (num == -1);
        }
        protected static void StringException(ref string str)
        {
            do
            {
                str = Console.ReadLine();
                IEnumerable<char> stringQuery = from c in str where Char.IsDigit(c) select c;
                foreach (char c in stringQuery)
                {
                    if (c >= '0' && c <= '9')
                    {
                        Console.WriteLine("\nOpps! Invalid data type");
                        Console.Write("Try again --> ");
                        str = null;
                        break;
                    }
                }
            } while (str == null);
        }
    }

    // Nota: Esta clase genérica implementa la colección List<T> para administrar las instancias de tipo
    // "CStudent" y "CProfessor".

    public class Organization<T>
    {
        public void AddMember(T mbr)
        {
            _staff.Add(mbr);
        }

        public void ShowMembers()
        {
            foreach(T mbr in _staff)
            {
                Console.WriteLine(mbr);
            }
        }

        public void ShowMemberIndexes()
        {
            int removeCounter = 0;
            foreach(T mbr in _staff)
            {
                Console.WriteLine($"| {removeCounter} | {mbr}");
                removeCounter++;
            }
        }

        public void RemoveMember(int mbr)
        {
            _staff.RemoveAt(mbr);
        }

        public void RemoveAllMembers()
        {
            _staff.Clear();
        }

        private List<T> _staff = new();
    }
}
