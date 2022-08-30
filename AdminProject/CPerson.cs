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

        private string _firstName;
        private string _lastName;
        private int _id;
        private int _age;

        public abstract void SetInfo();
        public abstract void GetInfo();

    }
}
