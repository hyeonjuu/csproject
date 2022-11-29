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
    public partial class Form1 : Form
    {
        main main;
        jogicdo jogicdo;
        private string empno;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string empno)
        {
            InitializeComponent();
            this.empno = empno;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            main = new main(empno);
            main.MdiParent = this;
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }

        private void 조직도ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jogicdo = new jogicdo();
            
            jogicdo.ShowDialog();
        }
    }
}
