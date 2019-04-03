using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Players
    {
        private String name;
        private int strikeout;
        private int walk;
        private Boolean atBat = false;

        public string Name { get => name; set => name = value; }
        public int Strikeout { get => strikeout; set => strikeout = value; }
        public int Walk { get => walk; set => walk = value; }
        public bool AtBat { get => atBat; set => atBat = value; }

        public Players(string name, int strikeout, int walk, bool atBat)
        {
            this.name = name;
            this.strikeout = strikeout;
            this.walk = walk;
            this.atBat = atBat;
        }

        public void update(int so, int w) {
            strikeout += so;
            walk += w;
        }

        public String toString()
        {
            return name + "," + strikeout + "," + walk + "\n";
        }
    }
}
