using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Mysql_Connection
{
    public partial class DB_Connection : Form
    {
        public DB_Connection()
        {
            InitializeComponent();
        }

        private void DB_Connection_Load(object sender, EventArgs e)
        {
            database.Enabled = false;
            connect.Enabled = false;
        }

        private void checkConnection_Click(object sender, EventArgs e)
        {
            try
            {
                // Make connection string
                string myConnectionString = "SERVER=" + server.Text + ";" + "UID=" + username.Text + ";" + "PASSWORD=" + password.Text + "; persistsecurityinfo=True; SslMode=none;";
                MySqlConnection connection = new MySqlConnection(myConnectionString);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "select SCHEMA_NAME from information_schema.SCHEMATA; ";
                MySqlDataReader Reader;
                connection.Open();
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    string row = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                    {
                        row += Reader.GetValue(i).ToString();
                        // Check if its not system DB
                        if (row != "information_schema" && row != "mysql" && row != "performance_schema" && row != "sys")
                        {
                            database.Items.Add(row);
                        }
                    }
                }
                database.SelectedIndex = 0;
                database.Enabled = true;
                connect.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Check information first");
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can save selected DB with MySql login information from in file with the project or in program settings as string to use it with your sql commands.");
        }
    }
}
