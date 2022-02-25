using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDB
{
    public partial class eventEdit : Form
    {
        MySqlConnection connection = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");

        public eventEdit()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE `events` SET name_event= '" + this.eventName.Text + "',date_event= '" + this.dateTimePicker1.Text + "', place_event= '" + this.eventPlace.Text + "'WHERE name_event = '" + textBox1.Text + "'and status_event=1;";
            cmd.ExecuteNonQuery();
            x.Text = "Event Edited Successfully !";
            connection.Close();
            eventName.Text = "";
            eventPlace.Text = "";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from `events` where name_event= '" + textBox1.Text + "';";
            cmd.ExecuteNonQuery();
            label2.Text = "Event Deleted Successfully !";
            connection.Close();
            eventName.Text = "";
            textBox1.Text = "";
            eventPlace.Text = "";
        }

        private void create_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO `events`(`name_event`, `date_event`,`place_event`,`status_event`) values('" + this.eventName.Text + "','" + this.dateTimePicker1.Text + "','" + this.eventPlace.Text + "','" + 1 + "');";
            cmd.ExecuteNonQuery();
            x.Text = "Event Created Successfully !";
            connection.Close();
            eventName.Text = "";
            eventPlace.Text = "";
        }
    }
}
