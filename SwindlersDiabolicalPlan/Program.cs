using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SwindlersDiabolicalPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            string workFolder = @"C:\MyOwnApps\GitLoc\HeadFirstCsharp\WorkFolder\";
            string workFilename = @"secret_plan.txt";
            StreamWriter sw = new StreamWriter(workFolder + workFilename);
            sw.WriteLine("How I’ll defeat Captain Amazing");
            sw.WriteLine("Another genius secret plan by The Swindler");
            sw.Write("I’ll create an army of clones and ");
            sw.WriteLine("unleash them upon the citizens of Objectville.");
            string location = "the mall";
            for (int number = 0; number <= 6; number++)
            {
                sw.WriteLine("Clone #{0} attacks {1}", number, location);
                if (location == "the mall") { location = "downtown"; }
                else { location = "the mall"; }
            }
            sw.Close();
        }
    }
}
