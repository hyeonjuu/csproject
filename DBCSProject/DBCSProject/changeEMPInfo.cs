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
    public partial class changeEMPInfo : Form
    {
        private int SelectedRowIndex;
        string sqlstr;
        DBClass dbc = new DBClass();
        DataTable empTable;

        EMPDetail EMPDetail;

  
        public changeEMPInfo(string empno)
        {
            InitializeComponent();
            dbc.DB_ObjCreate();
            dbc.DB_Open();
            dbc.DB_Access();
            dbc.EMPNO = empno;
        }

        public void emp_header()
        {
            dataGridView1.Columns[0].HeaderText = "사번";
            dataGridView1.Columns[1].HeaderText = "비밀번호";
            dataGridView1.Columns[2].HeaderText = "이름";
            dataGridView1.Columns[3].HeaderText = "부서";
            dataGridView1.Columns[4].HeaderText = "직급";
            dataGridView1.Columns[5].HeaderText = "전화번호";
            dataGridView1.Columns[6].HeaderText = "이메일";
            dataGridView1.Columns[7].HeaderText = "상태";
            dataGridView1.Columns[1].Visible = false;

            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dbc.DS.Clear();
                dbc.DA.Fill(dbc.DS, "emp");
                empTable = dbc.DS.Tables["emp"];
                if (e.RowIndex < 0)
                {
                    // DBGrid의 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                    // 아무 메시지도 띄우지 않습니다. return;
                }
                else if (e.RowIndex > empTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = empTable.Rows[e.RowIndex];
                pNo.Text = currRow["NO"].ToString();
                pName.Text = currRow["NAME"].ToString();
                pRank.Text = currRow["RANK"].ToString();
                pDepartment.Text = currRow["DEPT"].ToString();
                pTel.Text = currRow["TEL"].ToString();
                pEmail.Text = currRow["EMAIL"].ToString();
                pStatus.Text = currRow["STATUS"].ToString();

                SelectedRowIndex = Convert.ToInt32(currRow["NO"]);
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            dbc.DA.Fill(dbc.DS, "emp");
            empTable = dbc.DS.Tables["emp"];

            DataRow[] ResultRows = empTable.Select("NO like '%" + pNo.Text + "%'");

            foreach (DataRow currRow in ResultRows)
            {
                pName.Text = currRow["NAME"].ToString();
                pRank.Text = currRow["RANK"].ToString();
                pDepartment.Text = currRow["DEPT"].ToString();
                pTel.Text = currRow["TEL"].ToString();
                pEmail.Text = currRow["EMAIL"].ToString();
                pStatus.Text = currRow["STATUS"].ToString();
            }
        }

        private void appendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DS.Clear();
                dbc.DA.Fill(dbc.DS, "emp");

                DataTable empTable = dbc.DS.Tables["emp"];
                DataRow newRow = empTable.NewRow();
                newRow["NO"] = Convert.ToInt32(pNo.Text);
                newRow["NAME"] = pName.Text;
                newRow["RANK"] = pRank.Text;
                newRow["DEPT"] = pDepartment.Text;
                newRow["TEL"] = pTel.Text;
                newRow["EMAIL"] = pEmail.Text;
                newRow["STATUS"] = pStatus.Text;

                empTable.Rows.Add(newRow);
                dbc.DA.Update(dbc.DS, "emp");
                dataGridView1.DataSource = dbc.DS.Tables["emp"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DS.Clear();
                dbc.DA.Fill(dbc.DS, "emp");

                empTable = dbc.DS.Tables["emp"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = empTable.Columns["NO"];
                empTable.PrimaryKey = PrimaryKey;

                DataRow currRow = empTable.Rows.Find(SelectedRowIndex);

                currRow.BeginEdit();
                currRow["NO"] = pNo.Text;
                currRow["NAME"] = pName.Text;
                currRow["RANK"] = pRank.Text;
                currRow["DEPT"] = pDepartment.Text;
                currRow["TEL"] = pTel.Text;
                currRow["EMAIL"] = pEmail.Text;
                currRow["STATUS"] = pStatus.Text;
                currRow.EndEdit();

                DataSet UpdatedSet = dbc.DS.GetChanges(DataRowState.Modified);

                if(UpdatedSet.HasErrors)
                {
                    MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                }
                else
                {
                    dbc.DA.Update(UpdatedSet, "emp");
                    dbc.DS.AcceptChanges();
                }
                dataGridView1.DataSource = dbc.DS.Tables["emp"].DefaultView;
            }
            catch(DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch(Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
            
        }

        private void empdetailBtn_Click(object sender, EventArgs e)
        {
            EMPDetail = new EMPDetail();
            EMPDetail.Show();
        }

        private void changeEMPInfo_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate();
                dbc.DB_Open();
                dbc.DB_Access();

                sqlstr = "select * from emp";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "emp");
                dbc.DS.Tables["emp"].Clear();
                dbc.DA.Fill(dbc.DS, "emp");
                dataGridView1.DataSource = dbc.DS.Tables["emp"].DefaultView;
                emp_header();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
   
        }

        private void 조직도ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }
    }
}
