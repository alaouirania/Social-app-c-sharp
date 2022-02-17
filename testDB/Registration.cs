using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace testDB
{
    public partial class Registration : Form
    {
        MySqlConnection connection = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");

        public Registration()
        {
            InitializeComponent();

        }
        private void register_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO `registration`(`userame`, `adressmail`, `password`) values('" + this.username.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "');";
            cmd.ExecuteNonQuery();
            label4.Text = "Account Added Successfully !";
            connection.Close();
            this.Hide();
            menu m = new menu();
            m.Show();


        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}