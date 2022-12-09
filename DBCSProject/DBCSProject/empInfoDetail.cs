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
    public partial class EMPDetail : Form
    {
        private int SelectedRowIndex;
        string sqlstr;
        DBClass dbc = new DBClass();
        DataTable detailTable;

        public EMPDetail()
        {
            InitializeComponent();
            dbc.DB_ObjCreate();
            dbc.DB_Open();
            dbc.DB_Access();
        }
        public EMPDetail(string empno)
        {
            InitializeComponent();
            dbc.DB_ObjCreate();
            dbc.DB_Open();
            dbc.DB_Access();
            dbc.EMPNO = empno;
        }
        public void detail_header()
        {
            dataGridView1.Columns[0].HeaderText = "사번";
            dataGridView1.Columns[1].HeaderText = "생년월일";
            dataGridView1.Columns[2].HeaderText = "고용형태";
            dataGridView1.Columns[3].HeaderText = "주 근무시간";
            dataGridView1.Columns[4].HeaderText = "연간 연차시간";
            dataGridView1.Columns[5].HeaderText = "입사일";
        }

        private void EMPDetail_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate();
                dbc.DB_Open();
                dbc.DB_Access();

                sqlstr = "select * from additional";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "additional");
                dbc.DS.Tables["additional"].Clear();
                dbc.DA.Fill(dbc.DS, "additional");
                dataGridView1.DataSource = dbc.DS.Tables["additional"].DefaultView;
                detail_header();
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            dbc.DA.Fill(dbc.DS, "additional");
            detailTable = dbc.DS.Tables["additional"];

            DataRow[] ResultRows = detailTable.Select("NO like '%" + pNo.Text + "%'");

            foreach (DataRow currRow in ResultRows)
            {
                pBirth.Text = currRow["BIRTH"].ToString();
                pType.Text = currRow["TYPE"].ToString();
                pWorking.Text = currRow["WORKINGHOUR"].ToString();
                pVacation.Text = currRow["VACATIONHOUR"].ToString();
                pDate.Text = currRow["ENTRY"].ToString();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DS.Clear();
                dbc.DA.Fill(dbc.DS, "additional");

                detailTable = dbc.DS.Tables["additional"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = detailTable.Columns["NO"];
                detailTable.PrimaryKey = PrimaryKey;

                DataRow currRow = detailTable.Rows.Find(SelectedRowIndex);

                currRow.BeginEdit();
                currRow["NO"] = pNo.Text;
                currRow["BIRTH"] = pBirth.Text;
                currRow["TYPE"] = pType.Text;
                currRow["WORKINGHOUR"] = pWorking.Text;
                currRow["VACATIONHOUR"] = pVacation.Text;
                currRow["ENTRY"] = pDate.Text;
                currRow.EndEdit();

                DataSet UpdatedSet = dbc.DS.GetChanges(DataRowState.Modified);

                if (UpdatedSet.HasErrors)
                {
                    MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                }
                else
                {
                    dbc.DA.Update(UpdatedSet, "additional");
                    dbc.DS.AcceptChanges();
                }
                dataGridView1.DataSource = dbc.DS.Tables["additional"].DefaultView;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dbc.DS.Clear();
                dbc.DA.Fill(dbc.DS, "additional");
                detailTable = dbc.DS.Tables["additional"];
                if (e.RowIndex < 0)
                {
                    // DBGrid의 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                    // 아무 메시지도 띄우지 않습니다. return;
                }
                else if (e.RowIndex > detailTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = detailTable.Rows[e.RowIndex];
                pNo.Text = currRow["NO"].ToString();
                pBirth.Text = currRow["BIRTH"].ToString();
                pType.Text = currRow["TYPE"].ToString();
                pWorking.Text = currRow["WORKINGHOUR"].ToString();
                pVacation.Text = currRow["VACATIONHOUR"].ToString();
                pDate.Text = currRow["ENTRY"].ToString();

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

        private void 직원검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            dbc.DA.Fill(dbc.DS, "additional");
            detailTable = dbc.DS.Tables["additional"];

            DataRow[] ResultRows = detailTable.Select("NO like '%" + pNo.Text + "%'");

            foreach (DataRow currRow in ResultRows)
            {
                pBirth.Text = currRow["BIRTH"].ToString();
                pType.Text = currRow["TYPE"].ToString();
                pWorking.Text = currRow["WORKINGHOUR"].ToString();
                pVacation.Text = currRow["VACATIONHOUR"].ToString();
                pDate.Text = currRow["ENTRY"].ToString();
            }
        }
    }
}
