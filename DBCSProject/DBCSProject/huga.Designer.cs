
namespace DBCSProject
{
    partial class huga
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.근태관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.근태현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.휴가신청ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내근무조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조직도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.근무정보관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(76, 171);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 30F);
            this.label1.Location = new System.Drawing.Point(436, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "휴가 신청";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(418, 207);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 84);
            this.textBox2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "사유";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 21);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "신청";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(461, 171);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 16);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "오전반차(4h)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(571, 171);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 16);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "오후 반차(4h)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(374, 171);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 16);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "연차(8h)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(751, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(276, 150);
            this.dataGridView1.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "종류";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "총";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 42;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "사용";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 54;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "잔여";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(809, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "내 휴가 통계";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.근태관리ToolStripMenuItem,
            this.조직도ToolStripMenuItem,
            this.직원관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 근태관리ToolStripMenuItem
            // 
            this.근태관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.근태현황ToolStripMenuItem,
            this.휴가신청ToolStripMenuItem,
            this.내근무조회ToolStripMenuItem});
            this.근태관리ToolStripMenuItem.Name = "근태관리ToolStripMenuItem";
            this.근태관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
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
            this.조직도ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.조직도ToolStripMenuItem.Text = "조직도";
            // 
            // 직원관리ToolStripMenuItem
            // 
            this.직원관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.직원정보수정ToolStripMenuItem,
            this.근무정보관리ToolStripMenuItem});
            this.직원관리ToolStripMenuItem.Name = "직원관리ToolStripMenuItem";
            this.직원관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.직원관리ToolStripMenuItem.Text = "직원관리";
            // 
            // 직원정보수정ToolStripMenuItem
            // 
            this.직원정보수정ToolStripMenuItem.Name = "직원정보수정ToolStripMenuItem";
            this.직원정보수정ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.직원정보수정ToolStripMenuItem.Text = "직원 정보 관리";
            // 
            // 근무정보관리ToolStripMenuItem
            // 
            this.근무정보관리ToolStripMenuItem.Name = "근무정보관리ToolStripMenuItem";
            this.근무정보관리ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.근무정보관리ToolStripMenuItem.Text = "근무 정보 관리";
            // 
            // huga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "huga";
            this.Text = "휴가 신청";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 근태관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 근태현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 휴가신청ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 내근무조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조직도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원정보수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 근무정보관리ToolStripMenuItem;
    }
}