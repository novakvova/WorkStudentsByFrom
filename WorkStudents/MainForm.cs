using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkStudents
{
    public partial class MainForm : Form
    {
        private readonly SQLiteConnection _con;
        public MainForm()
        {
            InitializeComponent();
            try
            {
                string dbName = 
                    ConfigurationManager.AppSettings["DatabaseName"];
                _con = new SQLiteConnection($"Data Source={dbName}");
                _con.Open();


            }
            catch(Exception ex)
            {
                MessageBox.Show($"Помилка роботи програми: {ex.Message}");
            }
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuCreateDB_Click(object sender, EventArgs e)
        {
            string query =
                "CREATE TABLE IF NOT EXISTS tblGroups(" +
                "Id integer PRIMARY KEY," +
                "Name text NOT NULL);";
            SQLiteCommand cmd = new SQLiteCommand(query, _con);
            cmd.ExecuteNonQuery();
        }

        private void menuGroups_Click(object sender, EventArgs e)
        {

        }
    }
}
