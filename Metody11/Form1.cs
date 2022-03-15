using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int PocetSlov(string retezec,out string retezecBezCifer)
        {
            string s = retezec;
            char[] oddelovace = { ' ' };
            retezecBezCifer = s;
            string[] slova = s.Split(oddelovace, StringSplitOptions.RemoveEmptyEntries);
            int pocetSlov = slova.Length;
            retezecBezCifer = s;
            for (int i = 0; i < retezecBezCifer.Length; ++i)
            {
                

                    if (char.IsDigit(retezecBezCifer[i])){
                    retezecBezCifer = retezecBezCifer.Remove(i, 1);
                    ++i;

                    }
                
            }

            return pocetSlov;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retezec = textBox1.Text;
            string s;
            int pocSlov = PocetSlov(retezec, out s);
            MessageBox.Show("Pocet slov v retezci je " + pocSlov +" retezec bez cislic je " + s);
        }
    }
}
