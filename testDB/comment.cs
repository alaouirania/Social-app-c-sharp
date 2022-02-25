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
    public partial class comment : Form
    {
        MySqlConnection connection = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");

        public comment()
        {

            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT id, post,comment FROM `posts`order by id desc limit 10;";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
            connection.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE `posts` SET comment= '"+textBox1.Text+"' WHERE id = '" + textBox5.Text + "';";
            cmd.ExecuteNonQuery();
            txt.Text = "Comment Added !";
            textBox1.Text = "";
            textBox5.Text = "";
            connection.Close();

        }

        private void comment_Load(object sender, EventArgs e)
        {

        }
    }
}
