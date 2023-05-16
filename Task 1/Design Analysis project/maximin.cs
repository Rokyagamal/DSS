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
    public partial class maximin : UserControl
    {
        float x1, x2, x3, y1, y2, y3, z1, z2, z3,
             min1, min2, min3 =  0;
        public maximin()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox8.Text != "" & textBox9.Text != "")
            {
                //  1      row 1
                x1 = float.Parse(textBox1.Text);
                y1 = float.Parse(textBox2.Text);
                z1 = float.Parse(textBox3.Text);
                min1 = Math.Min(Math.Min(x1, y1), z1);

                ///////////////////////////////////////////////////////////////

                // 2      row 2
                x2 = float.Parse(textBox4.Text);
                y2 = float.Parse(textBox5.Text);
                z2 = float.Parse(textBox6.Text);
                min2 = Math.Min(Math.Min(x2, y2), z2);

                ///////////////////////////////////////////////////////////////

                // 3      row 3
                x3 = float.Parse(textBox7.Text);
                y3 = float.Parse(textBox8.Text);
                z3 = float.Parse(textBox9.Text);
                min3 = Math.Min(Math.Min(x3, y3), z3);

                ///////////////////////////////////////////////////////////////

                if (Math.Max(Math.Max(min1, min2), min3) == min1)
                {
                    label10.Text = "Invest in " + label1.Text;
                }
                else if (Math.Max(Math.Max(min1, min2), min3) == min2)
                {
                    label10.Text = "Invest in " + label3.Text;
                }
                else
                {
                    label10.Text = "Invest in " + label4.Text;
                }
                label8.Text = (Math.Max(Math.Max(min1, min2), min3)).ToString();
            }
            else
            {
                MessageBox.Show("please Enter All data ");
            }
        }
    }
}
