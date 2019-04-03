using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class exportRoster
    {
        public void exportPlayers(ArrayList p)
        {
            String output = "";
            foreach(Players player in p)
            {
                output += player.toString() + "\n";
            }
            System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", output);
        }
    }
}
