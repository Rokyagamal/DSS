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
    public partial class EMV : UserControl
    {
        float x1, x2, x3, y1, y2, y3, z1, z2, z3, p1, p2, p3 = 0;
        public EMV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox8.Text != "" & textBox9.Text != "" & textBox10.Text != "" & textBox11.Text != "" & textBox12.Text != "")
            {
                //  1      row 1
                x1 = float.Parse(textBox1.Text);
                y1 = float.Parse(textBox2.Text);
                z1 = float.Parse(textBox3.Text);

                ///////////////////////////////////////////////////////////////

                // 2      row 2
                x2 = float.Parse(textBox4.Text);
                y2 = float.Parse(textBox5.Text);
                z2 = float.Parse(textBox6.Text);

                ///////////////////////////////////////////////////////////////

                // 3      row 3
                x3 = float.Parse(textBox7.Text);
                y3 = float.Parse(textBox8.Text);
                z3 = float.Parse(textBox9.Text);

                ///////////////////////////////////////////////////////////////
                ///

                p1 = float.Parse(textBox10.Text) * x1 +
                    float.Parse(textBox11.Text) * y1 +
                    float.Parse(textBox12.Text) * z1;

                p2 = float.Parse(textBox10.Text) * x2 +
                    float.Parse(textBox11.Text) * y2 +
                    float.Parse(textBox12.Text) * z2;

                p3 = float.Parse(textBox10.Text) * x3 +
                    float.Parse(textBox11.Text) * y3 +
                    float.Parse(textBox12.Text) * z3;

                // EMV

                if (Math.Max(Math.Max(p1, p2), p3) == p1)
                {
                    label10.Text = "Invest in " + label1.Text;
                }
                else if (Math.Max(Math.Max(p1, p2), p3) == p2)
                {
                    label10.Text = "Invest in " + label3.Text;
                }
                else
                {
                    label10.Text = "Invest in " + label4.Text;
                }
                label8.Text = (Math.Max(Math.Max(p1, p2), p3)).ToString();
            }
            else
            {
                MessageBox.Show("please Enter All data ");
            }
        }
    }
}
