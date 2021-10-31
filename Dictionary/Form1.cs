using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dictionary_wordsConnectionString);
        string query;
        SqlCommand cmd;
        string wordid, meaning;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadList();
        }


        private void LoadList()
            //..........< Load ListBox with Database words >..........
        {
            //..........< Database >..........
            if (conn.State != ConnectionState.Open) conn.Open();
            query = "SELECT word FROM wordstocks ORDER BY word";
            DataTable tb1 = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(tb1);
            conn.Close();
            //..........</ Database >.........

            //..........< Show >..........
            wordList.DisplayMember = "word";    //database field to show
            combo_Search.DisplayMember = "word";    //database field to show
            wordList.DataSource = tb1;
            combo_Search.DataSource = tb1;
            //..........</ Show >.........
        }
        //..........</ Load ListBox with Database words >..........


        private void wordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //..........< Read Meaning >..........
            if (conn.State != ConnectionState.Open) conn.Open();
            query = "SELECT id, b_meaning FROM wordstocks WHERE word = '" + wordList.GetItemText(wordList.SelectedItem).Replace("'", "''") + "'";
            cmd = new SqlCommand(query, conn);
            SqlDataReader fetchdata = cmd.ExecuteReader();
            while(fetchdata.Read())
            {
                wordid = fetchdata.GetValue(0).ToString();
                meaning = fetchdata.GetValue(1).ToString();
            }
            cmd.Dispose();
            conn.Close();
            //..........</ Read Meaning >.........

            //..........< Print >..........
            word_ID.Text = "ID: " + wordid;
            displayBox.Text = meaning;
        }
    }
}
