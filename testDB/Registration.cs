using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace testDB
{
    public partial class Registration : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Registration()
        {
            server = "127.0.0.1";
            database = "social_medias";
            uid = "root";
            password = "";
            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            conn = new MySqlConnection(connString);
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Register(username.Text, admail.Text, password_r.Text);
        }
        public bool Register(string userame, string adressmail, string password)
        {
            string query = $"INSERT INTO registration (id,userame,adressmail,password) VALUES ('',{userame},{adressmail},{password})";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("No Connection");
                        break;
                    case 1045:
                        MessageBox.Show("Server username/mail/password incorrect");
                        break;
                }
                return false;
            }
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

