using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public abstract class CPerson
    {
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Id { get => _id; set => _id = value; }
        public int Age { get => _age; set => _age = value; }

        public abstract void SetInfo();

        private string _firstName;
        private string _lastName;
        private int _id;
        private int _age;
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
