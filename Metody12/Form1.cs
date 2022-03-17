using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool ObsahujeSlovo(string retezec, out string nejdelsiSLovo,out string nejkratsiSlovo)
        {
            char[] oddelovace = { ' ' };
            string[] slova = retezec.Split(oddelovace, StringSplitOptions.RemoveEmptyEntries);

            nejdelsiSLovo = slova.Max();
            nejkratsiSlovo = slova.Min();

            return (slova.Length > 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retezec = textBox1.Text;
            string nejdelSlovo;
            string nejkratSlovo;
            if (ObsahujeSlovo(retezec, out nejdelSlovo, out nejkratSlovo))
            {
                MessageBox.Show(" Retezec obsahuje alespon jedno slovo, nejdelsi slovo v retezci je " + nejdelSlovo + " a nejkratsi slovo je " + nejkratSlovo);
            }
            else MessageBox.Show(" Retezec neobsahuje ani jedno slovo");
        }
    }
}
