using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace testDB
{
    public partial class FriendsSuggestion : Form
    {
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        MySqlConnection connection = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");

        public FriendsSuggestion()
        {
            InitializeComponent();
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
           

            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT `name_ff` FROM `findfriends`;";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView3.DataSource = dtRecord;
            connection.Close();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from `findfriends` where name_ff= '" + this.textBox1.Text + "';";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO `myfriends`(`name_friend`) values('" + this.textBox1.Text +"');";
            cmd.ExecuteNonQuery();
            connection.Close();
            label20.Text = "Friend Added Successfully !";
            textBox1.Text = "";



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void searchData(string valueToSearch)
        {
            string query = "SELECT `id_ff`,`name_ff` FROM findfriends WHERE CONCAT(`name_ff`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView3.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchData("");
            string valueToSearch = textBox1.Text.ToString();
            searchData(valueToSearch);

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

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
