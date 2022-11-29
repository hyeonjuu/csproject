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
    public partial class myWork : Form
    {
        DBClass dbc = new DBClass();
        public myWork()
        {
            InitializeComponent();
        }
    }

    public void thisMonthWork()
    {
        try
        {
            string thisMonth = DateTime.Today.Year.ToString() + "/" + DateTime.Today.Month.ToString();


            sqlstr = "Select * from workstatus where empno = '" + dbc.EMPNO + "'and month = '" + thisMonth + "'";
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "workstatus");

            DataRow currRow = dbc.DS.Tables["workstatus"].Rows[0];

            progressBar1.Maximum = Convert.ToInt32(currRow["plantime"]);
            progressBar1.Value = Convert.ToInt32(currRow["currenttime"]);

            WSCurrent.Text = currRow["currenttime"].ToString() + "h";
            WSPlan.Text = currRow["plantime"].ToString() + "h";


        }
        catch (DataException DE)
        {
            MessageBox.Show(DE.Message);
        }
    }
}
