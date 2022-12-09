using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCSProject
{
    public partial class empWork : Form
    {
        DBClass dbc = new DBClass();
        string sqlstr;
        public empWork(string empno,string dept)
        {
            InitializeComponent();
            dbc.EMPNO = empno;
            dbc.DEPT = dept;
        }


        private void getEmp()
        {
            dbc.DS.Clear();
            string searchT = dbc.DEPT.Substring(0, 3);
            label7.Text = searchT;
            sqlstr = "select e.no , e.name,d.name,e.rank from emp e,dept d where dept like '%" + searchT + "%' and e.dept = d.code";
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "empwork");

            dbc.Table = dbc.DS.Tables["empwork"];
            dataGridView1.DataSource = dbc.Table;
        }
        private void getEmpAll()
        {
            dbc.DS.Clear();
            
            sqlstr = "select e.no, e.name,d.name,e.rank from emp e,dept d where e.dept = d.code";
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "empwork");

            dbc.Table = dbc.DS.Tables["empwork"];
            dataGridView1.DataSource = dbc.Table;
        }


        private void empWork_Load(object sender, EventArgs e)
        {
            dbc.DB_ObjCreate();
            dbc.DB_Open();
            dbc.DB_Access();

            if (dbc.DEPT.Equals("ES000"))
            {
                getEmpAll();
            }
            else
            {
                getEmp();
            }

            

        }
    }
}
