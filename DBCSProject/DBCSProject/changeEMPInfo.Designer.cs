
namespace DBCSProject
{
    partial class changeEMPInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.직급 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.근태관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.근태현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.휴가신청ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내근무조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조직도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.근무정보관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.직급,
            this.Column8,
            this.Column6,
            this.Column4,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(71, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 328);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "사번";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "이름";
            this.Column1.Name = "Column1";
            // 
            // 직급
            // 
            this.직급.HeaderText = "직급";
            this.직급.Name = "직급";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "부서";
            this.Column8.Name = "Column8";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "전화번호";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "이메일";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "상태";
            this.Column7.Name = "Column7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 514);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "사번";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 510);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 579);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(261, 574);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 28);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 642);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "직급";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(261, 638);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 28);
            this.textBox3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 710);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "부서";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(261, 705);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 28);
            this.textBox4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 514);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "전화번호";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(617, 510);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 28);
            this.textBox5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 579);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "이메일";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(617, 574);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(141, 28);
            this.textBox6.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 642);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "상태";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(617, 638);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(141, 28);
            this.textBox7.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 710);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "이름";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(617, 705);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(141, 28);
            this.textBox8.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(906, 579);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(906, 645);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "수정";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.근태관리ToolStripMenuItem,
            this.조직도ToolStripMenuItem,
            this.직원관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1201, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 근태관리ToolStripMenuItem
            // 
            this.근태관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.근태현황ToolStripMenuItem,
            this.휴가신청ToolStripMenuItem,
            this.내근무조회ToolStripMenuItem});
            this.근태관리ToolStripMenuItem.Name = "근태관리ToolStripMenuItem";
            this.근태관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.근태관리ToolStripMenuItem.Text = "근태관리";
            // 
            // 근태현황ToolStripMenuItem
            // 
            this.근태현황ToolStripMenuItem.Name = "근태현황ToolStripMenuItem";
            this.근태현황ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.근태현황ToolStripMenuItem.Text = "근태현황";
            // 
            // 휴가신청ToolStripMenuItem
            // 
            this.휴가신청ToolStripMenuItem.Name = "휴가신청ToolStripMenuItem";
            this.휴가신청ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.휴가신청ToolStripMenuItem.Text = "휴가신청";
            // 
            // 내근무조회ToolStripMenuItem
            // 
            this.내근무조회ToolStripMenuItem.Name = "내근무조회ToolStripMenuItem";
            this.내근무조회ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.내근무조회ToolStripMenuItem.Text = "내 근무 조회";
            // 
            // 조직도ToolStripMenuItem
            // 
            this.조직도ToolStripMenuItem.Name = "조직도ToolStripMenuItem";
            this.조직도ToolStripMenuItem.Size = new System.Drawing.Size(55, 19);
            this.조직도ToolStripMenuItem.Text = "조직도";
            // 
            // 직원관리ToolStripMenuItem
            // 
            this.직원관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.직원정보수정ToolStripMenuItem,
            this.근무정보관리ToolStripMenuItem});
            this.직원관리ToolStripMenuItem.Name = "직원관리ToolStripMenuItem";
            this.직원관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.직원관리ToolStripMenuItem.Text = "직원관리";
            // 
            // 직원정보수정ToolStripMenuItem
            // 
            this.직원정보수정ToolStripMenuItem.Name = "직원정보수정ToolStripMenuItem";
            this.직원정보수정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.직원정보수정ToolStripMenuItem.Text = "직원 정보 관리";
            // 
            // 근무정보관리ToolStripMenuItem
            // 
            this.근무정보관리ToolStripMenuItem.Name = "근무정보관리ToolStripMenuItem";
            this.근무정보관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.근무정보관리ToolStripMenuItem.Text = "근무 정보 관리";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(906, 514);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "검색";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(906, 702);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "부가정보 보기";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 30F);
            this.label9.Location = new System.Drawing.Point(384, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 40);
            this.label9.TabIndex = 29;
            this.label9.Text = "직원 정보 관리";
            // 
            // changeEMPInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 795);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "changeEMPInfo";
            this.Text = "직원 정보 관리";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 직급;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 근태관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 근태현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조직도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원정보수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 근무정보관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 휴가신청ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 내근무조회ToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
    }
}