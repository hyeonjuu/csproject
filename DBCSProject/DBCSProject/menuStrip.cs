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
    public partial class menuStrip : Form
    {
        DBClass dbc = new DBClass();
        string command;

        public menuStrip(string command)
        {
            InitializeComponent();
            this.command = command;
        }
        public menuStrip(string empno ,string command)
        {
            InitializeComponent();
            dbc.EMPNO = empno;
            this.command = command;
        }
        private void getUpdate()
        {
            dbc.DCom.CommandText = "select * from emp where no = '" + dbc.EMPNO + "'";
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DS.Clear();
            int result = dbc.DA.Fill(dbc.DS, "emp");
            dbc.Table = dbc.DS.Tables["emp"];

            DataRow currRow = dbc.DS.Tables["emp"].Rows[0];
            pNo.Text = currRow["NO"].ToString();
            pName.Text = currRow["NAME"].ToString();
            pRank.Text = currRow["RANK"].ToString();
            pDepartment.Text = currRow["DEPT"].ToString();
            pTel.Text = currRow["TEL"].ToString();
            pEmail.Text = currRow["EMAIL"].ToString();
            pStatus.Text = currRow["STATUS"].ToString();
        }

        private void menuStrip_Load(object sender, EventArgs e)
        {
            dbc.DB_Access();
            dbc.DB_Open();
            dbc.DB_Access();
            if (command.Equals("추가"))
            {
                Btn.Text = "추가";
            } else if (command.Equals("수정"))
            {
                getUpdate();
                pNo.Enabled = false;
                Btn.Text = "수정";
            }
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (command.Equals("추가"))
            {
                dbc.DCom.CommandText = "insert into emp(no,name,dept,rank,tel,email,status) values(:no,:name,:dept,:rank,:tel,:email,:status)";
                dbc.DCom.Parameters.Add("no", OracleDbType.Varchar2).Value = pNo.Text;
                dbc.DCom.Parameters.Add("name", OracleDbType.Varchar2).Value = pName.Text;
                dbc.DCom.Parameters.Add("dept", OracleDbType.Varchar2).Value = pDepartment.Text;
                dbc.DCom.Parameters.Add("rank", OracleDbType.Varchar2).Value = pRank.Text;
                dbc.DCom.Parameters.Add("tel", OracleDbType.Varchar2).Value = pTel.Text;
                dbc.DCom.Parameters.Add("email", OracleDbType.Varchar2).Value = pEmail.Text;
                dbc.DCom.Parameters.Add("status", OracleDbType.Varchar2).Value = pStatus.Text;

                dbc.DCom.ExecuteNonQuery();
                this.Close();

            }
            else if (command.Equals("수정"))
            {
               
                dbc.DCom.CommandText = "update emp set name = :name, dept = :dept, rank=:rank , tel = :tel, email= :email, status=:status where no=:no";
                
                dbc.DCom.Parameters.Add("name", OracleDbType.Varchar2).Value = pName.Text;
                dbc.DCom.Parameters.Add("dept", OracleDbType.Varchar2).Value = pDepartment.Text;
                dbc.DCom.Parameters.Add("rank", OracleDbType.Varchar2).Value = pRank.Text;
                dbc.DCom.Parameters.Add("tel", OracleDbType.Varchar2).Value = pTel.Text;
                dbc.DCom.Parameters.Add("email", OracleDbType.Varchar2).Value = pEmail.Text;
                dbc.DCom.Parameters.Add("status", OracleDbType.Varchar2).Value = pStatus.Text;
                dbc.DCom.Parameters.Add("no", OracleDbType.Varchar2).Value = pNo.Text;

                dbc.DCom.ExecuteNonQuery();
                this.Close();
            }
        }
    }
}
