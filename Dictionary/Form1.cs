using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/Bangla_Dictionary.accdb");
        string query;
        OleDbCommand cmd;
        string wordid, meaning;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadList();
            //wordList.Items.Add("One");
            //wordList.Items.Add("Two");
            //wordList.Items.Add("Three");
            //wordList.Items.Add("Four");
            //wordList.Items.Add("Five");
            //wordList.Items.Add("Six");

            //combo_Search.Items.Add("One");
            //combo_Search.Items.Add("Two");
            //combo_Search.Items.Add("Three");
            //combo_Search.Items.Add("Four");
            //combo_Search.Items.Add("Five");
            //combo_Search.Items.Add("Six");
        }


        private void LoadList()
            //..........< Load ListBox with Database words >..........
        {
            //..........< Database >..........
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                query = "SELECT word FROM BengaliDictionary ORDER BY word";
                DataTable tb1 = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //..........</ Load ListBox with Database words >..........


        private void wordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //..........< Read Meaning >..........
                if (conn.State != ConnectionState.Open) conn.Open();
                query = "SELECT id, meaning FROM BengaliDictionary WHERE word = '" + wordList.GetItemText(wordList.SelectedItem).Replace("'", "''") + "'";
                cmd = new OleDbCommand(query, conn);
                OleDbDataReader fetchdata = cmd.ExecuteReader();
                while (fetchdata.Read())
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
