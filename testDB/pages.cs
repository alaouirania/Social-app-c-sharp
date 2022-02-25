using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace testDB
{
    public partial class pages : Form
    {
        MySqlConnection connection = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");

        public pages()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO `pages`(`name_pages`, `category_pages`, `status_pages`, `edit`) values('" + this.name_page.Text + "','" + this.category_page.SelectedItem.ToString() + "','" + this.status_page.SelectedItem.ToString() + "','"+1+"');";
            cmd.ExecuteNonQuery();
            pp.Text = "Page Created Successfully !";
            connection.Close();
            name_page.Text = "";
            category_page.Text = "";
            status_page.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            name_page.Text = "";
            category_page.Text = "";
            status_page.Text = "";
        }

        private void accueil_Click(object sender, EventArgs e)
        {
            DesignForm d = new DesignForm();
            d.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            connection.Open();  
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE `pages` SET name_pages= '" + this.name_page.Text + "',category_pages= '" + this.category_page.SelectedItem.ToString() + "', status_pages= '" + this.status_page.SelectedItem.ToString() + "'WHERE name_pages = '" + this.textBox1.Text + "'and edit=1;";
            cmd.ExecuteNonQuery();
            connection.Close();
            label2.Text = "Page Edited Successfully !";
            name_page.Text = "";
            category_page.Text = "";
            status_page.Text = "";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from `pages` where name_pages= '" + this.textBox1.Text + "';";
            cmd.ExecuteNonQuery();
            connection.Close();
            label2.Text = "Post Deleted Successfully !";
            textBox1.Text = "";
        }
    }
}
