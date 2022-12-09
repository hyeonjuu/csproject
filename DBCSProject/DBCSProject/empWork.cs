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
        
        public empWork(string empno,string dept)
        {
            InitializeComponent();
            dbc.EMPNO = empno;
            dbc.DEPT = dept;
        }





        private void empWork_Load(object sender, EventArgs e)
        {
            
        }
    }
}
