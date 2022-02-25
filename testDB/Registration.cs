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
            cmd.CommandText = "INSERT INTO `registration`(`name`,`userame`, `adressmail`, `password`, `status`) values('" + this.name_r.Text + "','" + this.username.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','"+1+"');";
            cmd.ExecuteNonQuery();
            connection.Close();
            label4.Text = "Account Added Successfully !";
            this.Hide();
            DesignForm m = new DesignForm();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}