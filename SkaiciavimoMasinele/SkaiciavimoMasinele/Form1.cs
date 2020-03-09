using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkaiciavimoMasinele
{
    public partial class Form1 : Form
    {
        private double atmintiesSk;   
        public Form1()
        {
            InitializeComponent();
            atmintiesSk = 0;
        }

        

        private void vienasBtn_Click(object sender, EventArgs e)
        {
            mainTxtBx.Text += '1';
        }

        private void duBtn_Click(object sender, EventArgs e)
        {
            mainTxtBx.Text += '2';
        }

        private void trysBtn_Click(object sender, EventArgs e)
        {
            mainTxtBx.Text += '3';
        }

        private void keturiBtn_Click(object sender, EventArgs e)
        {
            mainTxtBx.Text += '4';
        }

        private void penkiBtn_Click(object sender, EventArgs e)
        {
            mainTxtBx.Text += '5';
        }

        private void sesiBtn_Click(object sender, EventArgs e)
        {
            mainTxtBx.Text += '6';
        }
        private void septyniBtn_Click(object sender, EventArgs e)
        {
            mainTxtBx.Text += '7';
        }

        private void astuoniBtn_Click(object sender, EventArgs e)
        {
            mainTxtBx.Text += '8';
        }

        private void devyniBtn_Click(object sender, EventArgs e)
        {
            mainTxtBx.Text += '9';
        }

        private void pliusBtn_Click(object sender, EventArgs e)
        {
            if (mainTxtBx.Text != "")
            {
                atmintiesSk += Convert.ToDouble(mainTxtBx.Text);
                mintisTxtBx.Text = atmintiesSk + " + ";
                mainTxtBx.Clear();
            }
            
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (mainTxtBx.Text != "")
            {
                atmintiesSk -= Convert.ToDouble(mainTxtBx.Text);
                mintisTxtBx.Text = atmintiesSk + " - ";
                mainTxtBx.Clear();
            }
        }

        private void daugybaBtn_Click(object sender, EventArgs e)
        {
            if (mainTxtBx.Text != "")
            {
                if (atmintiesSk == 0)
                {
                    atmintiesSk = 1;
                }
                atmintiesSk *= Convert.ToDouble(mainTxtBx.Text);
                mintisTxtBx.Text = atmintiesSk + " * ";

                mainTxtBx.Clear();
            }
        }

        private void dalybaBtn_Click(object sender, EventArgs e)
        {
            if (mainTxtBx.Text != "")
            {
                if (atmintiesSk == 0)
                {
                    atmintiesSk = 1;
                }
                atmintiesSk /= Convert.ToDouble(mainTxtBx.Text);
                mintisTxtBx.Text = atmintiesSk + " / ";

                mainTxtBx.Clear();
            }
        }

        private void lyguBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void trintiBtn_Click(object sender, EventArgs e)
        {
            mainTxtBx.Clear();
            mintisTxtBx.Text = "";
        }

        private void kablelisBtn_Click(object sender, EventArgs e)
        {
            if (!mainTxtBx.Text.Contains(','))
            {
                if (mainTxtBx.Text == "")
                {
                    mainTxtBx.Text += '0' + ',';
                }
                else
                {
                    mainTxtBx.Text += ',';
                }
            }
        }

        private void nulisBtn_Click(object sender, EventArgs e)
        {
            mainTxtBx.Text += '0';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
