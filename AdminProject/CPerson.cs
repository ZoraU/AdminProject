using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public abstract class CPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        public abstract void SetInfo();
        public abstract void GetInfo();

    }
}
