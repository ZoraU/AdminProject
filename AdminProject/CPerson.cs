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
        protected string FirstName { get; set; } 
        protected string LastName { get; set; }
        protected long Id { get; set; }
        protected long Age { get; set; }

        public abstract void SetInfo();
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
