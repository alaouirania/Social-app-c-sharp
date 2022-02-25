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
    public partial class EventForm : Form
    {
        MySqlConnection connection = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");

        public EventForm()
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
    }
}
