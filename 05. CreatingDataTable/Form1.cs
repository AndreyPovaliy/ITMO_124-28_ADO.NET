﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05.CreatingDataTable
{
    public partial class Form1 : Form
    {
        private DataTable CustomersTable = new DataTable("Customers");
        public Form1()
        {
            InitializeComponent();
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            TableGrid.DataSource = CustomersTable;
            CustomersTable.Columns.Add("CustomerID", Type.GetType("System.String"));
            CustomersTable.Columns.Add("CompanyName", Type.GetType("System.String"));
            CustomersTable.Columns.Add("ContactName", Type.GetType("System.String"));
            CustomersTable.Columns.Add("ContactTitle", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Address", Type.GetType("System.String"));
            CustomersTable.Columns.Add("City", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Country", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Phone", Type.GetType("System.String"));
            DataColumn[] KeyColumns = new DataColumn[1];
            KeyColumns[0] = CustomersTable.Columns["CustomerID"];
            CustomersTable.PrimaryKey = KeyColumns;
            CustomersTable.Columns["CustomerID"].AllowDBNull = false;
            CustomersTable.Columns["CompanyName"].AllowDBNull = false;
            DataRow CustRow = CustomersTable.NewRow();
            Object[] CustRecord =  {"ALFKI", "Alfreds Futterkiste", "Maria Anders",
                "Sales Representative", "Obere Str. 57", "Berlin",
                  null, "12209", "Germany", "030-0074321","030-0076545"};
            CustRow.ItemArray = CustRecord;
            CustomersTable.Rows.Add(CustRow);



        }
    }
}
