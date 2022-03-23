using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_OOP2
{
    public class NakladniAuto
    {
        private string spz;
        private int nosnost;
        private int naklad = 0;
        public int hmotnostnakladu { get { return naklad; } }

        public NakladniAuto(string spz, int nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }
       
        public void NalozNaklad(int hmotnostnakladu)
        {
            if (hmotnostnakladu > nosnost)
            {
                naklad = nosnost;
                MessageBox.Show("Naloženo bylo " + hmotnostnakladu + " tun. Přebytek je " + (hmotnostnakladu - naklad) + " tun.");
            }
            else
            {
                naklad = hmotnostnakladu;
                MessageBox.Show("Náklad se úspěšně naložil.");
            }
        }

        public void VylozNaklad(int hmotnostnakladu)
        {
            if (hmotnostnakladu > naklad) {
                MessageBox.Show("Náklad byl vyložen, ale chybí " + (hmotnostnakladu - naklad) + " tun.");
                naklad = 0;
            }
            else {
                MessageBox.Show("Náklad byl úspěšně vyložen.");
                naklad = 0;
            }
        }

        public override string ToString()
        {
            return String.Format("Nákladní auto {0} má nosnost {1} tun a má naloženo {2} tun nákladu.", spz, nosnost, naklad);
        }
    }
}

