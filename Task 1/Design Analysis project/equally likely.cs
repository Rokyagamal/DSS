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
    public partial class equally_likely : UserControl
    {
        int row1, row2, row3 = 0;
        public equally_likely()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox8.Text != "" & textBox9.Text != "")
            {
                row1 = ((int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text)) / 3);

                row2 = ((int.Parse(textBox4.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text)) / 3);

                row3 = ((int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text)) / 3);

                if (Math.Max(Math.Max(row1, row2), row3) == row1)
                {
                    label10.Text = "Invest in " + label1.Text;
                }
                else if (Math.Max(Math.Max(row1, row2), row3) == row2)
                {
                    label10.Text = "Invest in " + label3.Text;
                }
                else
                {
                    label10.Text = "Invest in " + label4.Text;
                }
                label8.Text = (Math.Max(Math.Max(row1, row2), row3)).ToString();
            }
            else
            {
                MessageBox.Show("please Enter All data ");
            }
        }
    }
}
