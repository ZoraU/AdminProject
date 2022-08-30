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
            SEstudiante sEstudiante_1 = new SEstudiante();
            SEstudiante sEstudiante_2 = new SEstudiante();

            sEstudiante_1.AddEstudiante();
            Console.WriteLine();
            sEstudiante_2.AddEstudiante();
            Console.WriteLine();

            sEstudiante_1.getInfoEstudiante();
            sEstudiante_2.getInfoEstudiante();
        }
    }
}
