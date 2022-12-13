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



        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
                string code = e.Node.Tag.ToString();

            DBClass dbc = new DBClass();
            dbc.DB_Access();
            dbc.DB_Open();
                dbc.DCom.CommandText = "select e.name,e.rank,d.name ,e.tel,e.email from emp e , dept d where e.dept = :dept and e.dept = d.code order by e.no asc";
                dbc.DCom.Parameters.Add("dept", OracleDbType.Varchar2).Value = code;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "emp");
                if (dbc.DS.Tables["emp"].Rows.Count <= 0)
                {
                    return;
                }
                empTable = dbc.DS.Tables["emp"];

                comboBox1.Items.Clear();

                foreach (DataRow currRow in empTable.Rows)
                {
                    comboBox1.Items.Add(currRow["NAME"].ToString() + " " + currRow["RANK"].ToString());
                }
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            dbc.DCom.CommandText = "select e.name,e.rank,d.name ,e.tel,e.email from emp e, dept d where e.name like '%" + pSearch.Text + "%' and e.dept = d.code order by e.no asc";
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "emp");
            empTable = dbc.DS.Tables["emp"];
            comboBox1.Items.Clear();

            foreach (DataRow currRow in empTable.Rows)
            {
                comboBox1.Items.Add(currRow["NAME"].ToString() + " " + currRow["RANK"].ToString());
            }
        }

        private void organizationChart_Load(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            dbc.DCom.CommandText = "select e.name,e.rank,d.name ,e.tel,e.email from emp e , dept d where e.dept = d.code order by e.no asc";
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "emp");
            empTable = dbc.DS.Tables["emp"];
            

            comboBox1.Items.Clear();

            foreach (DataRow currRow in empTable.Rows)
            {
                comboBox1.Items.Add(currRow["NAME"].ToString() + " " + currRow["RANK"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex < 0)
            {
                return;
            }
            int index = comboBox1.SelectedIndex;
            DataRow currRow = empTable.Rows[index];


            pName.Text = currRow["name"].ToString();
            pEmail.Text = currRow["email"].ToString();
            pTel.Text = currRow["tel"].ToString();
            pRank.Text = currRow["rank"].ToString();
            pDepartment.Text = currRow["name1"].ToString();
        }
    }
}
