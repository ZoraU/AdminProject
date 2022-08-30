using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            SStudent sEstudiante_1 = new SStudent();
            SStudent sEstudiante_2 = new SStudent();

            sEstudiante_1.AddEstudiante();
            Console.WriteLine();
            sEstudiante_2.AddEstudiante();
            Console.WriteLine();

            sEstudiante_1.getInfoEstudiante();
            sEstudiante_2.getInfoEstudiante();
        }
    }
}
