using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Identicke(string retezec1, string retezec2, out int indexPrvniOdlisnosti, out int pocetOdlisnosti)
        {
            bool jeIdentic;
            pocetOdlisnosti = 0;
            indexPrvniOdlisnosti = -1;
            if (retezec1 == retezec2)
            {
                jeIdentic = true;
            }
            else
            {
                jeIdentic = false;

                int minDelka = Math.Min(retezec1.Length, retezec2.Length);
                for (int i = 0; i < minDelka; i++)
                {
                    if (retezec1[i] != retezec2[i])
                    {
                        pocetOdlisnosti++;
                        if (indexPrvniOdlisnosti == -1)
                        {
                            indexPrvniOdlisnosti = i;
                        }
                    }
                }

                int lenghtDifference = Math.Abs(retezec1.Length - retezec2.Length);
                pocetOdlisnosti += lenghtDifference;
                if (indexPrvniOdlisnosti == -1)
                {
                    indexPrvniOdlisnosti = minDelka;
                }
            }
            return jeIdentic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retezec1 = textBox1.Text;
            string retezec2 = textBox2.Text;
            int indexPrvniOdlisnosti;
            int pocetOdlisnosti;


            if (Identicke(retezec1, retezec2, out indexPrvniOdlisnosti, out pocetOdlisnosti))
            {
                MessageBox.Show("Retezce jsou naprosto shodne");
                //MessageBox.Show("Retezce jsou naprosto shodne\nIndex prvni odlisnosti: " + indexPrvniOdlisnosti + "\nPocet odlisnosti: " + pocetOdlisnosti);

            }
            else
            {
                MessageBox.Show("Retezce nejsou naprosto shodne\nIndex prvni odlisnosti: " + indexPrvniOdlisnosti + "\nPocet odlisnosti: " + pocetOdlisnosti);
            }
        }
    }
}
