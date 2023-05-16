using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Design_Analysis_project
{
    public partial class Form1 : Form
    {
        string username, password, Query;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BTS79AO;Initial Catalog=Home_Rento;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            username = textBox1.Text;
            password = textBox2.Text;
            try
            {
                Query = "select * from [dbo].[login] where username = '"+username+"' and Password = '"+password+"'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    password = textBox2.Text;

                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details..");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
            
        }
    }
}
