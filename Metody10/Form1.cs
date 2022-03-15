using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public bool ObsahujeCislici(string retezec,out int cifSoucet,out int lichCifSoucet,out int sudCifSoucet)
        {
            bool obsahuje = false;
             cifSoucet = 0;
             lichCifSoucet = 0;
             sudCifSoucet = 0;
            foreach(int znak in retezec)
            {
                if(znak >= '0' && znak <= '9')
                {
                    obsahuje = true;
                    cifSoucet += znak;
                    if (znak % 2 == 0)
                    {
                        sudCifSoucet += znak;
                    }
                    else lichCifSoucet += znak;
                }
                
            }

            return obsahuje;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string retezec = textBox1.Text;
            int sudCifSouc;
            int lichCifSouc;
            int cifSouc;
            if (ObsahujeCislici(retezec, out cifSouc, out lichCifSouc, out sudCifSouc))
                {
                MessageBox.Show("Retezec obsahuje cifru, ciferny soucet cifer je " + cifSouc + " soucet lichych cifer je " + lichCifSouc + " soucet sud cifer je" + sudCifSouc);
            }
            else MessageBox.Show(" Neobsahuje cifru");
        }
    }
}
