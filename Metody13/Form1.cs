using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool JeAlfanum(string retezec, out int pocetMalPis, out int pocetVelPis, out int pocetJinychZnaku)
        {

            bool Je = true;
            pocetMalPis = 0;
            pocetVelPis = 0;
            pocetJinychZnaku = 0;
            foreach(char znak in retezec)
            {
                if (char.IsLetterOrDigit(znak))
                {
                    if (char.IsLower(znak))
                    {
                        ++pocetMalPis;
                    }

                    if (char.IsUpper(znak))
                    {
                        ++pocetVelPis;
                    }
                }
                else
                {
                    Je = false;
                    pocetJinychZnaku++;
                }
            }

            return Je;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string retezec = textBox1.Text;
            int pMalPis;
            int pVelPis;
            int pJinZnak;
            if (JeAlfanum(retezec, out pMalPis, out pVelPis, out pJinZnak))
            {
                MessageBox.Show("Retezec je alfanumericky a obsahuje " + pMalPis + " malych pismen, " + pVelPis + " velkych pismen a " + pJinZnak + " jinych znaku");
            }
            else MessageBox.Show(" Retezec neni jenom alfanumericky a obsahuje " + pMalPis + " malych pismen, " + pVelPis + " velkych pismen a " + pJinZnak + " jinych znaku");
        }
    }
}
