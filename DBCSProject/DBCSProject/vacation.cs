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
    public partial class vacation : Form
    {
        string sqlstr;
        string startTime;
        string stopTime;
        bool dateAvailable = false;


        DBClass dbc = new DBClass();

        public vacation(string empno)
        {
            InitializeComponent();
            dbc.EMPNO = empno;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dbc.DB_Access();
            dbc.DB_ObjCreate();
            dbc.DB_Open();
            myAnnual();
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            int result = DateTime.Compare(monthCalendar1.SelectionStart, DateTime.Now);
            if(result <= 0)
            {
                MessageBox.Show("선택할 수 없습니다.");
                dateAvailable = false;
            }
            else if (monthCalendar1.SelectionStart.DayOfWeek == DayOfWeek.Sunday || monthCalendar1.SelectionStart.DayOfWeek == DayOfWeek.Saturday)
            {
                MessageBox.Show("주말은 선택할 수 없습니다.");
                dateAvailable = false;
            }
            else
            {
                dateAvailable = true;
            }
        }

        private void vacation_FormClosing(object sender, FormClosedEventArgs e)
        {
            this.MdiParent.Width = 1100;
            this.MdiParent.Height = 730;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateAvailable == false)
                {
                    MessageBox.Show("해당 날짜엔 신청할 수 없습니다.");
                    return;
                }
                if (startTime == null || stopTime == null)
                {
                    MessageBox.Show("종류를 선택하세요.");
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("사유를 입력하세요.");
                    return;
                }
                
                DBClass newdb = new DBClass();
                newdb.DB_Access();
                string atndDate = monthCalendar1.SelectionStart.ToString("yy/MM/dd");
                
                sqlstr = "insert into attendance(empno,atnddate,atndtype,starttime,stoptime,note) values(:empno,:atnddate,'휴가',:starttime,:stoptime,:note)";
                newdb.DCom.CommandText = sqlstr;
                newdb.DCom.Parameters.Add("empno", OracleDbType.Varchar2).Value = dbc.EMPNO;
                newdb.DCom.Parameters.Add("atnddate", OracleDbType.Varchar2).Value = atndDate;
                newdb.DCom.Parameters.Add("starttime", OracleDbType.Varchar2).Value = startTime;
                newdb.DCom.Parameters.Add("stoptime", OracleDbType.Varchar2).Value = stopTime;
                newdb.DCom.Parameters.Add("note", OracleDbType.Varchar2).Value = textBox2.Text;
                
                if (MessageBox.Show("휴가 신청 하시겠습니까?", "왓", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    newdb.DCom.ExecuteNonQuery();
                    MessageBox.Show("신청되었습니다.");
                    dateAvailable = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("이미 신청된 날짜입니다.");
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            startTime = "09:00:00";
            stopTime = "18:00:00";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            startTime = "09:00:00";
            stopTime = "13:00:00";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            startTime = "13:00:00";
            stopTime = "18:00:00";
        }
    }
}
