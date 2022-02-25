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
    public partial class Settings : Form
    {
        MySqlConnection connection = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");

        public Settings()
        {
            InitializeComponent();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE `registration` SET name= '"+ nameSettings.Text+ "',adressmail= '" + mailSettings.Text +"', password= '" + passwordSettings.Text + "'WHERE adressmail = '"+ textBox1.Text+"'and status=1;";
            cmd.ExecuteNonQuery();
            s.Text = "Settings Changed !";
            connection.Close();
            nameSettings.Text = "";
            mailSettings.Text = "";
            passwordSettings.Text = "";

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
