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
    public partial class message : Form
    {
        MySqlConnection connection = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");

        public message()
        {
            InitializeComponent();
        }

        private void message_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            label4.Text = this.textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT `name_friend` FROM `myfriends`;";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = this.textBox2.Text+"  "+DateTime.Now.ToString();
            label5.BackColor = System.Drawing.Color.LightSeaGreen;
            textBox2.Text = "";
        }
    }
}
