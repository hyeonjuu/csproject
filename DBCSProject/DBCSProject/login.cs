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
    public partial class login : Form
    {
        string sqlstr;
        DBClass dbc = new DBClass();
        DataRow currRow;
        public login()
        {
            InitializeComponent();
            dbc.DB_Open();
            dbc.DB_Access();
        }
        public void isAdmin()
        {

        }
        public int Login(string no, string password)
        {
            try
            {
                dbc.DS.Clear();
                sqlstr = "Select * from emp where no = '" +no + "'";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "user");
                dbc.Table = dbc.DS.Tables["user"];
                if (dbc.Table.Rows.Count == 0)
                {
                    return -2;
                }
                currRow = dbc.Table.Rows[0];
                
                if (currRow["password"].Equals(password))
                {
                    if (currRow["rank"].Equals("이사"))
                    {
                        dbc.EMPNO = no;
                        return 3;
                    }
                    else if(currRow["rank"].Equals("팀장") || currRow["rank"].Equals("지점장") || currRow["rank"].Equals("부장"))
                    {
                        dbc.EMPNO = no;
                        return 2;
                    }
                    else
                    {
                        dbc.EMPNO = no;
                        return 1;
                    }
                }
                else 
                {
                    return -1;
                }
            } catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            return -2;
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            int result = Login(id.Text, password.Text);
            switch (result)
            {
                case 1:
                    this.Hide();
                    Form1 form1 = new Form1(id.Text);
                    form1.Owner = this;
                    form1.ShowDialog();
                    this.Close();
                    break;
                case 2:
                    this.Hide();
                    Admin admin = new Admin(id.Text,currRow["dept"].ToString());
                    admin.Owner = this;
                    admin.ShowDialog();
                    this.Close();
                    break;
                case 3:
                    this.Hide();
                    Executive executive = new Executive(id.Text, currRow["dept"].ToString());
                    executive.Owner = this;
                    executive.ShowDialog();
                    this.Close();
                    break;
                case -1:
                    MessageBox.Show("비밀번호 불 일치");
                    break;
                case -2:
                    MessageBox.Show("일치하는 사원번호가 없습니다.");
                    break;
            }
        }
        public String userNO { get { return dbc.EMPNO; } set { dbc.EMPNO = value; } }
    }
}
