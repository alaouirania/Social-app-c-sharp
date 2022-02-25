using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace testDB
{

    public partial class groupEdit : Form
    {
        MySqlConnection connection = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");

        public groupEdit()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try { 
            connection.Open(); 
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE `groups` SET group_name= '" + grpNAme.Text + "',group_category= '" + grpCategory.SelectedItem.ToString() + "', group_members= '" + grpMembers.SelectedItem.ToString() + "'WHERE group_name = '" + textBox1.Text + "'and status_group=1;";
            cmd.ExecuteNonQuery();
            label2.Text = "Group Edited Successfully !";
            connection.Close();
            grpNAme.Text = "";
            grpCategory.Text = "";
            grpMembers.Text = "";
            textBox1.Text = "";
            }
            catch(Exception ex)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                label2.ForeColor=System.Drawing.Color.Red;
                label2.Text = "Not able to edit the post !";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from `groups` where group_name= '" + textBox1.Text + "';";
            cmd.ExecuteNonQuery();
            label3.Text = "Post Deleted Successfully !";
            connection.Close();
            grpNAme.Text = "";
            grpCategory.Text = "";
            grpMembers.Text = "";
            textBox1.Text = "";
        }

        private void grpPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            grpNAme.Text = "";
            grpCategory.Text = "";
            grpMembers.Text = "";
            textBox1.Text = "";
        }
    }
}
