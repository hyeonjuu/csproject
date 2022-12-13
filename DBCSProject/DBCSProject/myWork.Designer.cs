
namespace DBCSProject
{
    partial class MyWork
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
            this.label1 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.planLabel = new System.Windows.Forms.Label();
            this.WSPlan = new System.Windows.Forms.Label();
            this.WSCurrent = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(435, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 67);
            this.label1.TabIndex = 28;
            this.label1.Text = "내 근무 현황";
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("돋움", 9F);
            this.stop.Location = new System.Drawing.Point(481, 252);
            this.stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(226, 25);
            this.stop.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label4.Location = new System.Drawing.Point(368, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "퇴근시간";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("돋움", 9F);
            this.start.Location = new System.Drawing.Point(481, 214);
            this.start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(226, 25);
            this.start.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label5.Location = new System.Drawing.Point(368, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "출근시간";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label7.Location = new System.Drawing.Point(368, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "유형";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label8.Location = new System.Drawing.Point(368, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "특이사항";
            // 
            // note
            // 
            this.note.Font = new System.Drawing.Font("돋움", 9F);
            this.note.Location = new System.Drawing.Point(481, 304);
            this.note.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(226, 92);
            this.note.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label9.Location = new System.Drawing.Point(368, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "승인 여부";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("돋움", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(481, 168);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 23);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("돋움", 9F);
            this.monthCalendar1.Location = new System.Drawing.Point(56, 172);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 41;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // planLabel
            // 
            this.planLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.planLabel.Location = new System.Drawing.Point(216, 50);
            this.planLabel.Name = "planLabel";
            this.planLabel.Size = new System.Drawing.Size(139, 24);
            this.planLabel.TabIndex = 43;
            this.planLabel.Text = "이달의 총 근무시간\r\n";
            this.planLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WSPlan
            // 
            this.WSPlan.Font = new System.Drawing.Font("돋움", 15F);
            this.WSPlan.Location = new System.Drawing.Point(221, 78);
            this.WSPlan.Name = "WSPlan";
            this.WSPlan.Size = new System.Drawing.Size(136, 24);
            this.WSPlan.TabIndex = 44;
            this.WSPlan.Text = "0h";
            this.WSPlan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WSCurrent
            // 
            this.WSCurrent.Font = new System.Drawing.Font("돋움", 15F);
            this.WSCurrent.Location = new System.Drawing.Point(35, 74);
            this.WSCurrent.Name = "WSCurrent";
            this.WSCurrent.Size = new System.Drawing.Size(152, 24);
            this.WSCurrent.TabIndex = 45;
            this.WSCurrent.Text = "0h";
            this.WSCurrent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentLabel
            // 
            this.currentLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.currentLabel.Location = new System.Drawing.Point(38, 50);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(155, 24);
            this.currentLabel.TabIndex = 46;
            this.currentLabel.Text = "이달의 현재 근무시간\r\n";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(40, 149);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Maximum = 160;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 29);
            this.progressBar1.TabIndex = 42;
            this.progressBar1.Value = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.planLabel);
            this.groupBox1.Controls.Add(this.WSPlan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.WSCurrent);
            this.groupBox1.Controls.Add(this.currentLabel);
            this.groupBox1.Font = new System.Drawing.Font("돋움", 9F);
            this.groupBox1.Location = new System.Drawing.Point(762, 172);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(393, 224);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, -5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 35);
            this.label6.TabIndex = 6;
            this.label6.Text = "이달의 근무";
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold);
            this.confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.confirm.Location = new System.Drawing.Point(479, 414);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(55, 15);
            this.confirm.TabIndex = 35;
            this.confirm.Text = "미승인";
            // 
            // MyWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.note);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MyWork";
            this.Text = "내 근무 현황";
            this.Load += new System.EventHandler(this.myWork_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label planLabel;
        private System.Windows.Forms.Label WSPlan;
        private System.Windows.Forms.Label WSCurrent;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}