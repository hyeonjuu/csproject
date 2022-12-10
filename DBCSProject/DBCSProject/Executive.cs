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
    public partial class Executive : Form
    {
        main main;
        organizationChart organizationChart;
        changeEMPInfo changeEmpInfo;
        empWork empWork;
        MyWork myWork;
        vacation vacation;

        private string empno;
        private string dept;

        public Executive()
        {
            InitializeComponent();
        }
        public Executive(string empno,string dept)
        {
            InitializeComponent();
            this.empno = empno;
            this.dept = dept;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            main = new main(empno);
            this.Width = 940;
            this.Height = 670;
            main.MdiParent = this;
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }

        private void 조직도ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            organizationChart = new organizationChart();
            
            organizationChart.Show();
        }

        private void 휴가신청ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vacation == null || vacation.IsDisposed)
            {
                this.Width = 1220;
                this.Height = 600;
                vacation = new vacation(empno);
                vacation.MdiParent = this;
                vacation.WindowState = FormWindowState.Maximized;
                vacation.Show();
                
            }
            else
            {
                vacation.Activate();
            }
        }

        private void 내근무현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myWork == null || myWork.IsDisposed)
            {
                this.Width = 1220;
                this.Height = 600;
                myWork = new MyWork(empno);
                myWork.MdiParent = this;
                myWork.WindowState = FormWindowState.Maximized;
                myWork.Show();
            }
            else
            {
                myWork.Activate();
            }
        }

        private void 직원근태현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (empWork == null || empWork.IsDisposed)
            {
                this.Width = 1220;
                this.Height = 610;
                empWork = new empWork(empno,dept);
                empWork.MdiParent = this;
                empWork.WindowState = FormWindowState.Maximized;
                empWork.Show();
                

            }
            else
            {
                empWork.Activate();
            }
        }



        private void 직원정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changeEmpInfo == null || changeEmpInfo.IsDisposed)
            {
                changeEmpInfo = new changeEMPInfo(empno);
                changeEmpInfo.MdiParent = this;
                changeEmpInfo.WindowState = FormWindowState.Maximized;
                changeEmpInfo.Show();
            }
            else
            {
                changeEmpInfo.Activate();
            }
        }
    }
}
