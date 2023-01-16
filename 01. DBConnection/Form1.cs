using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection.Emit;

namespace _01.DBConnection
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        string testConnect;

        public string L_Data
        {
            get
            { return label1.Text; }
            set
            { label1.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
            this.connection.StateChange += new
                System.Data.StateChangeEventHandler(
                this.connection_StateChange);


        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    L_Data = "Соединение с базой данных выполнено успешно";


                }
                else
                    L_Data = "Соединение с базой данных уже установлено";
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                L_Data = "Соединение с базой данных закрыто";
            }
            else
                L_Data = "Соединение с базой данных уже закрыто";

        }

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            connectToolStripMenuItem.Enabled =
                (e.CurrentState == ConnectionState.Closed);
            disconnectToolStripMenuItem.Enabled =
                (e.CurrentState == ConnectionState.Open);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                testConnect= @"Provider=SQLOLEDB.1;Integrated Security=SSPI;
                                Persist Security Info=False;Initial Catalog=Northwind;
                                Data Source=WIN-CDJM1LM10O7\SQLEXPRESS";
            }
            else
            {
                testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;
                                Persist Security Info=False;
                                Initial Catalog=Northwind;Data Source=(local)";
            }
        }
    }
}
