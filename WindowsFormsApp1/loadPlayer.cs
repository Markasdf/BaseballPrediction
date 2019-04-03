using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class loadPlayer
    {
        public void test() {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");

            ArrayList Roster = new ArrayList();
            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                String[] temp = line.Split(',');
                Players p = new Players(temp[0], temp[1]);
            }
        }
    }
}
