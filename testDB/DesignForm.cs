using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace testDB
{
    public partial class DesignForm : Form
    {

        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
            
        
        pages page = new pages();
        
        
        MySqlConnection connection = new MySqlConnection(@"Data Source=127.0.0.1;port=3306;Initial Catalog=social_medias;User Id=root;password=''");

        public DesignForm()
        {
            InitializeComponent();
        }

        private void data_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Cursor = DefaultCursor;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows= false;
            dataGridView3.AllowUserToAddRows= false;
            dataGridView4.AllowUserToAddRows=false;

            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT id, post, liked,comment FROM `posts`order by id desc limit 10;";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord; 
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT `name_pages`,`category_pages` FROM `pages` order by id_pages desc limit 8;";
            MySqlDataAdapter sqlDataAdap1 = new MySqlDataAdapter(cmd);
            DataTable dtRecord1 = new DataTable();
            sqlDataAdap1.Fill(dtRecord1);
            dataGridView3.DataSource = dtRecord1;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  `group_name`,`group_category` FROM `groups` order by id DESC limit 5;";
            MySqlDataAdapter sqlDataAdap2 = new MySqlDataAdapter(cmd);
            DataTable dtRecord2 = new DataTable();
            sqlDataAdap2.Fill(dtRecord2);
            dataGridView2.DataSource = dtRecord2;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  `name_event`,`place_event` FROM `events` order by id_event DESC limit 5;";
            MySqlDataAdapter sqlDataAdap4 = new MySqlDataAdapter(cmd);
            DataTable dtRecord4 = new DataTable();
            sqlDataAdap4.Fill(dtRecord4);
            dataGridView4.DataSource = dtRecord4;
            connection.Close();
        }
     

        private void button2_Click(object sender, EventArgs e)
        {
            posts.Visible = true;
            posts.BringToFront();
            home.Visible = false;
            panel4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home.Visible = true;
            home.BringToFront();
            posts.Visible = false;
        }

        private void posts_Paint(object sender, PaintEventArgs e)
        {
            
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            FriendsSuggestion ff = new FriendsSuggestion();
            ff.Show();
        }

        private void groups_Click(object sender, EventArgs e)
        {
            groupForm grp = new groupForm();
            grp.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            eventEdit ef = new eventEdit();
            ef.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
        }

        private void post_Click_1(object sender, EventArgs e)
        {
            
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO `posts`(`post`,`status_post`) values('" + this.textBox1.Text + "','"+1+"');";
                cmd.ExecuteNonQuery();
                postTxt.Text = "Post Added Successfully !";
                connection.Close();
                textBox1.Text = "";
                
            
        }
        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        public void searchData(string valueToSearch)
        {
            string query = "SELECT `name_pages`  FROM pages WHERE CONCAT(`name_pages`) like '%" + valueToSearch + "%'";

            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView3.DataSource = table;
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            //Posts
            searchData("");
            string valueToSearch = textBox2.Text.ToString();
            searchData(valueToSearch);
        }

        public void searchDataEvent(string valueToSearch)
        {
            string query = "SELECT name_event FROM events WHERE CONCAT(`name_event`) like '%" + valueToSearch + "%'";

            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView4.DataSource = table;
        }

        private void eventBtn_Click(object sender, EventArgs e)
        {
            searchDataEvent("");
            string valueToSearch = textBox3.Text.ToString();
            searchDataEvent(valueToSearch);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.AllowUserToAddRows = false;
        }

        public void searchDataGroups(string valueToSearch)
        {
            string query = "SELECT group_name FROM groups WHERE CONCAT(`group_name`) like '%" + valueToSearch + "%'";

            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }
        private void groupsBtn_Click(object sender, EventArgs e)
        {
            searchDataGroups("");
            string valueToSearch = textBox4.Text.ToString();
            searchDataGroups(valueToSearch);
        }

      

        private void button9_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE `posts` SET post= '" +postEdit.Text + "'WHERE id = '" + textBox6.Text +"'and status_post='"+1+"';";
            cmd.ExecuteNonQuery();
            postTxt.Text = "Post Edited !";
            connection.Close();
            textBox6.Text = "";
            postEdit.Text = "";

        }

        private void posts_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Login ln = new Login();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE `registration` SET status= 0 WHERE userame = '" + ln.textBox1.Text + "';";
            connection.Close();
            Login l = new Login();
            l.Show();
            this.Hide();


        }

        private void button11_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT id, post FROM `posts` where status_post = 1;";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView6.DataSource = dtRecord;
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT `name_pages`, `category_pages` FROM `pages` where edit = 1;";
            MySqlDataAdapter sqlDataAdap1 = new MySqlDataAdapter(cmd);
            DataTable dtRecord1 = new DataTable();
            sqlDataAdap1.Fill(dtRecord1);
            dataGridView5.DataSource = dtRecord1;
            connection.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();
            home.Visible = false;

        }

       

        private void button12_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from `posts` where id= '" + textBox6.Text + "'and status_post=1;";
            cmd.ExecuteNonQuery();
            postTxt.Text = "Post Deleted Successfully !";
            connection.Close();
            post.Text = "";
            textBox6.Text = "";
        }

      

        private void label5_Click(object sender, EventArgs e)
        {
            message m = new message();
            m.Show();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE `posts` SET Liked= 'Liked' WHERE id = '" + textBox5.Text + "';";
            cmd.ExecuteNonQuery();
            label21.Text = "Like Added !";
            connection.Close();
            textBox5.Text = "";
            label21.Text = "";
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE `posts` SET Liked= 'Not Liked' WHERE id = '" + textBox5.Text + "';";
            cmd.ExecuteNonQuery();
            label21.Text = "Post Disliked !";
            connection.Close();
            textBox5.Text = "";
            label21.Text = "";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            comment cm = new comment();
            cm.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void DesignForm_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pages p = new pages();
            p.Show();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
