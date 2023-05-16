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
    public partial class EOL : UserControl
    {
        float x1, x2, x3, y1, y2, y3, z1, z2, z3,
            max_x, max_y, max_z,
            Eol1, Eol2, Eol3, E0L = 0;
        public EOL()
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

                max_x = Math.Max(Math.Max(x1, x2), x3);   // column 1
                max_y = Math.Max(Math.Max(y1, y2), y3);   // column 2         
                max_z = Math.Max(Math.Max(z1, z2), z3);   // column 3


                Eol1 = (max_x - x1) * float.Parse(textBox10.Text) + (max_y - y1) * float.Parse(textBox11.Text) + (max_z - z1) * float.Parse(textBox12.Text);
                Eol2 = (max_x - x2) * float.Parse(textBox10.Text) + (max_y - y2) * float.Parse(textBox11.Text) + (max_z - z2) * float.Parse(textBox12.Text);
                Eol3 = (max_x - x3) * float.Parse(textBox10.Text) + (max_y - y3) * float.Parse(textBox11.Text) + (max_z - z3) * float.Parse(textBox12.Text);

                E0L = Math.Max(Eol1, Math.Max(Eol2, Eol3));

                if (Math.Max(Eol1, Math.Max(Eol2, Eol3)) == Eol1)
                {
                    label10.Text = "Invest in " + label1.Text;
                }
                else if (Math.Max(Eol1, Math.Max(Eol2, Eol3)) == Eol2)
                {
                    label10.Text = "Invest in " + label3.Text;
                }
                else
                {
                    label10.Text = "Invest in " + label4.Text;
                }
                label8.Text = Math.Max(Eol1, Math.Max(Eol2, Eol3)).ToString();
            }
            else
            {
                MessageBox.Show("please Enter All data ");
            }
        }
    }
}
