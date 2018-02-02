using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ctci_helpers;
using System.Windows.Forms;
namespace GetGuid
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
            Console.Write("Please number of GUIDS to generate: ");
            var input = Console.ReadLine();
            var numGuid = 0;
            if(!string.IsNullOrEmpty(input))
            {
                numGuid =  int.Parse(input);
            }
            else
            {
                Console.WriteLine("You must enter a valid number");
                return;
            }

            
            StringBuilder sb = new StringBuilder();

            Guid g;
            for (int i = 0; i < numGuid; i++)
            {
                Console.WriteLine();
                g = Guid.NewGuid();
                Console.WriteLine(g);
                sb.Append(g + "\n");
            }

            Clipboard.SetText(sb.ToString());
            CDis.Exit();
        }
    }
}
