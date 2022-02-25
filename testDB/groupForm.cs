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
    public partial class groupForm : Form
    {
        MySqlConnection connection = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");

        public groupForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO `groups`(`group_name`, `group_category`, `group_members`, `status_group`) values('" + this.grpName.Text + "','" + this.grpCategory.SelectedItem.ToString() + "','" + this.grpMembers.SelectedItem.ToString() + "','"+1+"');";
            cmd.ExecuteNonQuery();
            x.Text = "Group Created Successfully !";
            connection.Close();
            grpName.Text = "";
            grpCategory.Text = "";
            grpMembers.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grpName.Text = "";
            grpCategory.Text = "";
            grpMembers.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from `groups` where group_name= '" + textBox1.Text + "';";
            cmd.ExecuteNonQuery();
            x.Text = "Post Deleted Successfully !";
            connection.Close();
            grpName.Text = "";
            grpCategory.Text = "";
            grpMembers.Text = "";
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE `groups` SET group_name= '" + grpName.Text + "',group_category= '" + grpCategory.SelectedItem.ToString() + "', group_members= '" + grpMembers.SelectedItem.ToString() + "'WHERE group_name = '" + textBox1.Text + "'and status_group=1;";
                cmd.ExecuteNonQuery();
                x.Text = "Group Edited Successfully !";
                connection.Close();
                grpName.Text = "";
                grpCategory.Text = "";
                grpMembers.Text = "";
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                x.ForeColor = System.Drawing.Color.Red;
                x.Text = "Not able to edit the post !";
            }
        }
    }
}
