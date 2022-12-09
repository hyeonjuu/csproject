using Oracle.DataAccess.Client;
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
    public partial class MyWork : Form
    {
        DBClass dbc = new DBClass();
        string sqlstr;
        DataTable dt;

        public MyWork(string empno)
        {
            InitializeComponent();
            dbc.EMPNO = empno;
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

                DataRow currRow;
                if (dbc.DS.Tables["workstatus"].Rows.Count > 0)
                {
                    currRow = dbc.DS.Tables["workstatus"].Rows[0];
                    progressBar1.Maximum = Convert.ToInt32(currRow["plantime"]);
                    progressBar1.Value = Convert.ToInt32(currRow["currenttime"]);

                    WSCurrent.Text = currRow["currenttime"].ToString() + "h";
                    WSPlan.Text = currRow["plantime"].ToString() + "h";
                }



            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        private void load_attendance()
        {
            

        }

        private void myWork_Load(object sender, EventArgs e)
        {
            dbc.DB_Access();
            dbc.DB_Open();
            thisMonthWork();

            
        }




        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string atndDate = monthCalendar1.SelectionStart.ToString("yy/MM/dd");
            DBClass dbc = new DBClass();
            dbc.DB_Access();
            dbc.DB_Open();

            dbc.EMPNO = this.dbc.EMPNO;
            sqlstr = "select * from attendance where empno = :empno and atnddate = :atnddate order by atnddate asc";
            dbc.DCom.CommandText = sqlstr;
            dbc.DCom.Parameters.Add("empno", OracleDbType.Varchar2).Value = dbc.EMPNO;
            dbc.DCom.Parameters.Add("atnddate", OracleDbType.Varchar2).Value = atndDate;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "attendance");
            
            if(dbc.DS.Tables["attendance"].Rows.Count < 1)
            {
                MessageBox.Show("없습니다.");
                return;
            }
            dbc.Table = dbc.DS.Tables["attendance"];
            dt = dbc.DS.Tables["attendance"];

            comboBox1.Items.Clear();
            foreach (DataRow currRow in dbc.DS.Tables["attendance"].Rows)
            {
                comboBox1.Items.Add(currRow["atndtype"].ToString());
            }
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            DataRow currRow = dt.Rows[index];

            start.Text = currRow["starttime"].ToString();
            stop.Text = currRow["stoptime"].ToString();
            note.Text = currRow["note"].ToString();
            confirm.Text = currRow["confirm"].ToString();
           
        }
    }
    

}
