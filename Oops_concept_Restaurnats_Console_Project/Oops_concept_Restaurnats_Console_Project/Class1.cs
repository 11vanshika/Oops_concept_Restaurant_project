using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Oops_concept_Restaurnats_Console_Project.Program;

namespace Oops_concept_Restaurnats_Console_Project
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Restaurants obj = new Restaurants("Daliy Queen", "123 main", 5);
            obj.GenerateReceipt();

        }
    }
}
