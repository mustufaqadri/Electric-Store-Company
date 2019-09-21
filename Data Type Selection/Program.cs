using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Data_Type_Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Used Bool array as it takes one byte only for each status...
            bool[] GridStatus = new bool[24];

            String Line = "";
            // Reading statuses from file
            System.IO.StreamReader file = new System.IO.StreamReader(@"Q2Input.txt");
            int i = 0;
            while ((Line = file.ReadLine()) != null)
            {
                //System.Console.WriteLine(Line);
                if(Line.Contains("In")==true)
                {
                    GridStatus[i] = false;
                }
                else
                {
                    GridStatus[i] = true;
                }
                i++;
            }
            i = 0;
            for(int j=0;j<24;j++)
            {
                if(GridStatus[i]==true)
                {
                    System.Console.WriteLine("G" + (j + 1) + ", Active");
                }
                else
                {
                    System.Console.WriteLine("G" + (j + 1) + ", Inactive");
                }
                i++;
            }
        }
    }
}
