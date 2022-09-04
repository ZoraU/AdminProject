using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public abstract partial class CPerson
    {
        protected string FirstName { get => _firstName; set => _firstName = value; }
        protected string LastName { get => _lastName; set => _lastName = value; }
        protected int Id { get => _id; set => _id = value; }
        protected int Age { get => _age; set => _age = value; }

        public abstract void SetInfo();

        private string _firstName;
        private string _lastName;
        private int _id;
        private int _age;
    }
    public abstract partial class CPerson
    {
        protected void NumericException(int number)
        {
            do
            {
                try
                {
                    number = (int)Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    number = 0;
                    Console.WriteLine("\n¡Opps! You have entered an invalid data type");
                    Console.Write("Try again --> ");
                }
            } while (number == 0);
        }
        //protected void StringException(String str)
        //{
        //    do
        //    {
        //        try
        //        {
        //            str = Convert.ToString(Console.ReadLine());
        //            Console.WriteLine();
        //        }
        //        catch (FormatException)
        //        {
        //            str = null;
        //            Console.WriteLine("\n¡Opps! You have entered an invalid data type");
        //            Console.Write("Try again --> ");
        //        }
        //    // TODO: Ivestigar cómo validar un tipo string
        //    } while ();
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
