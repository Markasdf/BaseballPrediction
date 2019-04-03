using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class AtBats
    {
        public int balls = 0;
        public int strikes = 0;
        Players p;
        public AtBats(Players p)
        {
            this.p = p;
            strikes = 0;
            balls = 0;
            p.atBat = true;
        }
        public void setStrike()
        {
            if (strikes < 2)
            {
                strikes++;
            }
            else
            {
                strikes = 0;
                p.atBat = false;
                p.strikeout++;
            }
        }
        public void setBall()
        {
            if(balls < 3)
            {
                balls++;
            }
            else
            {
                balls = 0;
                p.atBat = false;
                p.walk++;
            }
        }



    }
}
