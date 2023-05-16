using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Analysis_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            evpi1.Visible = true;
            eVwPI1.Visible = false;
            eol1.Visible = false;
            emv1.Visible = false;
            equally_likely1.Visible = false;
            minimax_regret1.Visible = false;
            maximin1.Visible = false;
            maximax1.Visible = false;
            home1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            evpi1.Visible = false;
            eVwPI1.Visible = true;
            eol1.Visible = false;
            emv1.Visible = false;
            equally_likely1.Visible = false;
            minimax_regret1.Visible = false;
            maximin1.Visible = false;
            maximax1.Visible = false;
            home1.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            evpi1.Visible = false;
            eVwPI1.Visible = false;
            eol1.Visible = true;
            emv1.Visible = false;
            equally_likely1.Visible = false;
            minimax_regret1.Visible = false;
            maximin1.Visible = false;
            maximax1.Visible = false;
            home1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            emv1.Visible = true;
            evpi1.Visible = false;
            eVwPI1.Visible = false;
            eol1.Visible = false;
            equally_likely1.Visible = false;
            minimax_regret1.Visible = false;
            maximin1.Visible = false;
            maximax1.Visible = false;
            home1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            equally_likely1.Visible = true;
            evpi1.Visible = false;
            eVwPI1.Visible = false;
            eol1.Visible = false;
            emv1.Visible = false;
            minimax_regret1.Visible = false;
            maximin1.Visible = false;
            maximax1.Visible = false;
            home1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            minimax_regret1.Visible = true;
            equally_likely1.Visible = false;
            evpi1.Visible = false;
            eVwPI1.Visible = false;
            eol1.Visible = false;
            emv1.Visible = false;
            maximin1.Visible = false;
            maximax1.Visible = false;
            home1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maximin1.Visible = true;
            minimax_regret1.Visible = false;
            equally_likely1.Visible = false;
            evpi1.Visible = false;
            eVwPI1.Visible = false;
            eol1.Visible = false;
            emv1.Visible = false;
            maximax1.Visible = false;
            home1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maximax1.Visible = true;
            maximin1.Visible = false;
            minimax_regret1.Visible = false;
            equally_likely1.Visible = false;
            evpi1.Visible = false;
            eVwPI1.Visible = false;
            eol1.Visible = false;
            emv1.Visible = false;
            home1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1.Visible = true;
            maximax1.Visible = false;
            maximin1.Visible = false;
            minimax_regret1.Visible = false;
            equally_likely1.Visible = false;
            evpi1.Visible = false;
            eVwPI1.Visible = false;
            eol1.Visible = false;
            emv1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*Form1 form = new Form1();
           form.Show();
           this.Hide();*/
            string message = "            Do you want to exit: ";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
