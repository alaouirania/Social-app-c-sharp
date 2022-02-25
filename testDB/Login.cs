using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace testDB
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");
        int i;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select `userame`, `password` from registration where userame='" + textBox1.Text+"' and password='"+textBox3.Text+"'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                label3.Text = "Invalid username or password !";
            }
            else
            {
                cmd.CommandText = "UPDATE `registration` SET status= 1 WHERE userame = '" + textBox1.Text + "';";
                cmd.ExecuteNonQuery();
                this.Hide();
                DesignForm m = new DesignForm();
                m.Show();
            }
            con.Close();
        }

        private void linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration r = new Registration();
            r.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
