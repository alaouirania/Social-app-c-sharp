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
    public partial class Groups : Form
    {
        MySqlConnection connection = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");

        public Groups()
        {
            InitializeComponent();
        }

        private void Groups_Load(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO `events`(`name_event`, `date_event`,`place_event`,`status_event`) values('" + this.eventName.Text + "','" + this.dateTimePicker1.Text + "','" + this.eventPlace.Text + "','"+1+"');";
            cmd.ExecuteNonQuery();
            x.Text = "Event Created Successfully !";
            connection.Close();
            eventName.Text = "";
            eventPlace.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            eventName.Text = "";
            eventPlace.Text = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
