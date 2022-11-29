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
    public partial class main : Form
    {
        string sqlstr;
        string todayStatus;
        DBClass dbc = new DBClass();
        
        public main()
        {
            InitializeComponent();
            dbc.DB_ObjCreate();
            dbc.DB_Open();
            dbc.DB_Access();
        }
        public main(string empno)
        {
            InitializeComponent();
            dbc.DB_ObjCreate();
            dbc.DB_Open();
            dbc.DB_Access();
            dbc.EMPNO = empno;
        }

        public void getInfo()
        {
            try
            {
                dbc.DS.Clear();
                sqlstr = "Select * from emp where no = '" + dbc.EMPNO + "'";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "emp");
                dbc.PhoneTable = dbc.DS.Tables["emp"];
                
                DataRow currRow = dbc.PhoneTable.Rows[0];

                empInfo.Text = currRow["name"] + " : " + currRow["rank"];
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void getAttendance()
        {
            try
            {
                
                string today = DateTime.Today.Year.ToString() + "/" + DateTime.Today.Month.ToString()+"/" + DateTime.Today.Day.ToString();
                sqlstr = "Select atndtype from attendance where empno = :empno and atnddate = :atnddate";
             
                dbc.DCom.CommandText = sqlstr;
                dbc.DCom.Parameters.Add("empno", OracleDbType.Varchar2).Value = dbc.EMPNO;
                dbc.DCom.Parameters.Add("date", OracleDbType.Varchar2).Value = today;
                dbc.DR = dbc.DCom.ExecuteReader();

                if (dbc.DR.Read()) {

                    todayStatus = dbc.DR.GetValue(0).ToString();
                    status.Text = dbc.DR.GetValue(0).ToString();
                    if(status.Text != "")
                    {
                        button1.Enabled = false;                    }
                }
                else
                {
                    status.Text = "출근 전 입니다.";
                }

            } 
            catch(DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public void thisMonthWork()
        {
            try
            {
                string thisMonth = DateTime.Today.Year.ToString() +"/" +DateTime.Today.Month.ToString();

                
                sqlstr = "Select * from workstatus where empno = '" + dbc.EMPNO + "'and month = '"+thisMonth +"'";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "workstatus");

                DataRow currRow = dbc.DS.Tables["workstatus"].Rows[0];

                progressBar1.Maximum = Convert.ToInt32(currRow["plantime"]);
                progressBar1.Value = Convert.ToInt32(currRow["currenttime"]);

                WSCurrent.Text = currRow["currenttime"].ToString() + "h";
                WSPlan.Text = currRow["plantime"].ToString()+"h";
                
                
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public void annual_header()
        {
            dataGridView1.Columns[0].HeaderText = "연도";
            dataGridView1.Columns[1].HeaderText = "종류";
            dataGridView1.Columns[2].HeaderText = "총 시간";
            dataGridView1.Columns[3].HeaderText = "사용 시간";
            dataGridView1.Columns[4].HeaderText = "남은 시간";

            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
        }

        public void myAnnual()
        {
            try
            {

                string thisYear = DateTime.Now.Year.ToString();
                sqlstr = "Select year,type,total,total-leftover,leftover from annualstatus where empno = '" + dbc.EMPNO + "'and year = '" + thisYear + "'";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;

                dbc.DA.Fill(dbc.DS, "annual");

               

                dataGridView1.DataSource = dbc.DS.Tables["annual"].DefaultView;
                annual_header();

                /*for(int i = 0; i < dbc.DS.Tables["annual"].Rows.Count; i++)
                {
                    DataRow currRow = dbc.DS.Tables["annual"].Rows[i];
                    int totalAnnual = Convert.ToInt32(currRow["total"]);
                    int leftAnnual = Convert.ToInt32(currRow["leftover"]);
                    int useAnnual = totalAnnual - leftAnnual;
                    currRow["5"] = useAnnual;
                }*/

            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
       
        private void main_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; //타이머 간격 100ms
            timer1.Start();  //타이머 시작
            getInfo();
            thisMonthWork();
            myAnnual();
            getAttendance();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            today.Text = DateTime.Now.ToString("F");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DateTime.Now.Hour < 8)
            {
               MessageBox.Show("8시 이전엔 출근 등록을 할 수 없습니다.","알림");
            }
            
        }


    }
}
