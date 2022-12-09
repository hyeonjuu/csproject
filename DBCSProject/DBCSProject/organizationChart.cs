using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace DBCSProject
{
    public partial class organizationChart : Form
    {
        private int SelectedRowIndex;
        string sqlstr;
        DBClass dbc = new DBClass();
        DataTable empTable;

        public organizationChart()
        {
            InitializeComponent();
            dbc.DB_ObjCreate();
            dbc.DB_Open();
            dbc.DB_Access();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            dbc.DA.Fill(dbc.DS, "emp");
            empTable = dbc.DS.Tables["emp"];

            DataRow[] ResultRows = empTable.Select("NAME like '%" + pName.Text + "%'");

            listView1.Items.Clear();

            foreach(DataRow currRow in ResultRows)
            {
                listView1.Items.Add(currRow["NAME"].ToString());
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            dbc.DA.Fill(dbc.DS, "emp");
            empTable = dbc.DS.Tables["emp"];

            DataRow[] ResultRows = empTable.Select("NAME like '%" + pSearch.Text + "%'");

            DataColumn[] PrimaryKey = new DataColumn[1];
            PrimaryKey[0] = empTable.Columns["NO"];
            empTable.PrimaryKey = PrimaryKey;

            DataRow currRow = empTable.Rows.Find(listView1.Text.Substring(0, 2));

            dbc.SelectedKeyValue = Convert.ToInt32(currRow["name"].ToString());
            pName.Text = currRow["name"].ToString();
            pEmail.Text = currRow["email"].ToString();
            pTel.Text = currRow["tel"].ToString();
            pRank.Text = currRow["rank"].ToString();
            pDepartment.Text = currRow["dept"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            dbc.DA.Fill(dbc.DS, "emp");
            empTable = dbc.DS.Tables["emp"];

            DataRow[] ResultRows = empTable.Select("NAME like '%" + pSearch.Text + "%'");

            listView1.Items.Clear();

            foreach (DataRow currRow in ResultRows)
            {
                listView1.Items.Add(currRow["NO"].ToString() + " " + currRow["NAME"].ToString());
            }
        }
        
    }
}
