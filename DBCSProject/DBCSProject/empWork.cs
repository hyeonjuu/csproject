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
    public partial class empWork : Form
    {
        DBClass dbc = new DBClass();
        string sqlstr;
        
        DataRow currRow;

        public empWork(string empno,string dept)
        {
            InitializeComponent();
            dbc.EMPNO = empno;
            dbc.DEPT = dept;
        }

        public void gridView_header()
        {
            dataGridView1.Columns[0].HeaderText = "날짜";
            dataGridView1.Columns[1].HeaderText = "사번";
            dataGridView1.Columns[2].HeaderText = "이름";
            dataGridView1.Columns[3].HeaderText = "직급";
            dataGridView1.Columns[4].HeaderText = "유형";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "상태";
            dataGridView1.Columns[9].Visible = false;

        }
        private void getEmp()
        {
;           string searchT = dbc.DEPT;

            if (dbc.DEPT.Equals("ES000")){ 
                sqlstr = "select e.no, e.name,d.name,e.rank from emp e,dept d where e.dept = d.code order by no asc";
            }
            else if(searchT.EndsWith("000"))
            {
               searchT = dbc.DEPT.Substring(0, 3);
               sqlstr = "select e.no,e.name,d.name,e.rank from emp e,dept d where dept like '%" + searchT + "%' and e.dept = d.code order by no asc";
            }
            else
            {
                sqlstr = "select e.no,e.name,d.name,e.rank from emp e,dept d where dept ='" + searchT + "' and e.dept = d.code order by no asc";
            }
            
            dbc.DS.Clear();
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "empwork");

            dbc.Table = dbc.DS.Tables["empwork"];
            DataRowCollection rows = dbc.Table.Rows;
            foreach (DataRow dr in rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < dbc.Table.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                listView1.Items.Add(item);
            }
            listView1.Select();
        }

        private void empWork_Load(object sender, EventArgs e)
        {
            dbc.DB_ObjCreate();
            dbc.DB_Open();
            dbc.DB_Access();

            getEmp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            string searchT = dbc.DEPT;
            if (dbc.DEPT.Equals("ES000"))
            {
                sqlstr = "select e.no, e.name,d.name,e.rank from emp e,dept d where e.dept = d.code and e.name like '%"+pSearch.Text+"%' order by no asc";
            }
            else if (searchT.EndsWith("000"))
            {
                searchT = dbc.DEPT.Substring(0, 3);
                sqlstr = "select e.no,e.name,d.name,e.rank from emp e,dept d where dept like '%" + searchT + "%' and e.dept = d.code  and e.name like '%" + pSearch.Text + "%' order by no asc";
            }
            else
            {
                sqlstr = "select e.no,e.name,d.name,e.rank from emp e,dept d where dept ='" + searchT + "' and e.dept = d.code  and e.name like '%" + pSearch.Text + "%' order by no asc";
            }
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "emp");
            dbc.Table = dbc.DS.Tables["emp"];

            listView1.Items.Clear();
            DataRowCollection rows = dbc.Table.Rows;
            foreach (DataRow dr in rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < dbc.Table.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                listView1.Items.Add(item);
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string atndDate = monthCalendar1.SelectionStart.ToString("yy/MM/dd");

            string selectItem = listView1.SelectedItems[0].Text.ToString();


            sqlstr = "select a.atnddate,e.no, e.name,e.rank,a.atndtype,a.starttime,a.stoptime,a.note,a.confirm,a.time from emp e,attendance a where a.empno = e.no and e.no = '" + selectItem+"' and a.atnddate='"+atndDate+"' order by a.atnddate asc";
            dbc.DS.Clear();
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "emp");
            dbc.Table = dbc.DS.Tables["emp"];
            dataGridView1.DataSource = dbc.Table;
            gridView_header();

            //"select e.no,e.name,d.name,e.rank from emp e, dept d where dept = " + searchT + " and e.dept = d.code order by no asc;";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
           currRow = dbc.Table.Rows[e.RowIndex];

            type.Text = currRow["atndtype"].ToString();
            start.Text = currRow["starttime"].ToString();
            stop.Text = currRow["stoptime"].ToString();
            note.Text = currRow["note"].ToString();
            if (currRow["confirm"].Equals("미승인"))
            {
                nocheck.Checked = true;
            }
            else
            {
                check.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            string confirm = null;
            if (check.Checked)
            {
                confirm = "승인";
            }
            else
            {
                confirm = "미승인";
            }

            if(time.Text == "")
            {
                MessageBox.Show("시간을 입력하세요.");
                return;
            }
            if(!int.TryParse(time.Text,out _))
            {
                MessageBox.Show("근무 인정 시간 확인");
                return;
            }
                MessageBox.Show(confirm);
                DBClass dbc = new DBClass();
                dbc.DB_Access();
                dbc.DB_Open();
                dbc.EMPNO = this.dbc.EMPNO;

            DateTime d = (DateTime)currRow["atnddate"];
            sqlstr = "update attendance set note = :note,confirm = :confirm,confirmuser = :confirmuser,confirmtime = to_char(systimestamp,'hh24:mi:ss'), time = :time  where empno= :empno and atnddate = '"+d.ToString("yy/MM/dd")+"' and atndtype = :atndtype";
            dbc.DCom.CommandText = sqlstr;
            dbc.DCom.Parameters.Add("note", OracleDbType.Varchar2).Value = note.Text;
            dbc.DCom.Parameters.Add("confirm", OracleDbType.Varchar2).Value = confirm;
            dbc.DCom.Parameters.Add("confirmuser", OracleDbType.Varchar2).Value = dbc.EMPNO;
            dbc.DCom.Parameters.Add("time", OracleDbType.Varchar2).Value = time.Text;
            dbc.DCom.Parameters.Add("empno", OracleDbType.Varchar2).Value = currRow["no"].ToString();
            dbc.DCom.Parameters.Add("atndtype", OracleDbType.Varchar2).Value = type.Text;
            //dbc.DCom.Parameters.Add("atnddate", OracleDbType.Varchar2).Value = d.ToString("yy/MM/dd");

            dbc.DCom.ExecuteNonQuery();
            MessageBox.Show("수정되었습니다.");
                if (confirm.Equals("승인")) { 
                    if (type.Text.Equals("휴가")){
                        string month = DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString();
                    
                        sqlstr = "update annualstatus set leftover = (total - (select sum(time) from attendance where empno = '"+ currRow["no"].ToString() + "' and atnddate like '"+month.Substring(2,5)+ "%' and atndtype = '휴가')) where empno = '" + currRow["no"].ToString() + "' and year = '" + DateTime.Now.Year.ToString() + "' and type = '연차'";
                        dbc.DCom.CommandText = sqlstr;
                        dbc.DCom.ExecuteNonQuery();
                    }
                    else
                    {
                        string month = DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString();

                        sqlstr = "update workstatus set currenttime = (select sum(time) from attendance where empno =  '" + currRow["no"].ToString() + "' and atnddate like '" + month.Substring(2, 5) + "%' and(atndtype = '퇴근' or atndtype = '출근')) where empno =  '" + currRow["no"].ToString() + "' and month = '"+ month +"'";
                        dbc.DCom.CommandText = sqlstr;
                        dbc.DCom.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = null;
            if(listView1.SelectedItems.Count > 0) { 
            selectItem = listView1.SelectedItems[0].SubItems[0].Text;
            }

            sqlstr = "select a.atnddate, e.no, e.name,e.rank,a.atndtype,a.starttime,a.stoptime,a.note,a.confirm,a.time from emp e,attendance a where a.empno = e.no and e.no = '" + selectItem + "' and a.confirm = '미승인' order by a.atnddate asc";
            dbc.DS.Clear();
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "emp");
            dbc.Table = dbc.DS.Tables["emp"];
            dataGridView1.DataSource = dbc.Table;
            gridView_header();

        }

        
    }
}
