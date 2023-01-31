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
using System.Runtime.Remoting.Contexts;

namespace _17.Exam_task
{
    public partial class Database : Form
    {
        


        public Database()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            TableGrid.DataSource = ApressFinancialDataSet.Customers;
            TableGrid.MultiSelect = false;
            TableGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            TableGrid.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        



        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

       
        
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
