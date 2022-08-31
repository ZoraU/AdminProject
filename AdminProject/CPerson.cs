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

    public class SchoolOrganization<T>
    {
        public void AgregarMiembro(T mbr)
        {
            staff.Add(mbr);
        }

        public void MostrarMiembros()
        {
            foreach(T mbr in staff)
            {
                Console.WriteLine(mbr);
            }
        }

        public void MostrarIndicesMiembros()
        {
            int removeCounter = 0;
            foreach(T mbr in staff)
            {
                Console.WriteLine($"| {removeCounter} | {mbr}");
                removeCounter++;
            }
        }

        public void EliminarMiembro(int m)
        {
            staff.RemoveAt(m);
        }
        
        List<T> staff = new List<T>();
    }
}
