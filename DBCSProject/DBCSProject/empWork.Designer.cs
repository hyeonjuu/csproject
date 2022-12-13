
namespace DBCSProject
{
    partial class empWork
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
            this.button1 = new System.Windows.Forms.Button();
            this.nocheck = new System.Windows.Forms.RadioButton();
            this.check = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.note = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pSearch = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(504, 488);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 38);
            this.button1.TabIndex = 74;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nocheck
            // 
            this.nocheck.AutoSize = true;
            this.nocheck.Checked = true;
            this.nocheck.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.nocheck.Location = new System.Drawing.Point(625, 449);
            this.nocheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nocheck.Name = "nocheck";
            this.nocheck.Size = new System.Drawing.Size(75, 24);
            this.nocheck.TabIndex = 73;
            this.nocheck.TabStop = true;
            this.nocheck.Text = "미승인";
            this.nocheck.UseVisualStyleBackColor = true;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.check.Location = new System.Drawing.Point(504, 449);
            this.check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(60, 24);
            this.check.TabIndex = 72;
            this.check.Text = "승인";
            this.check.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(775, 392);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(415, 105);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // note
            // 
            this.note.Font = new System.Drawing.Font("돋움", 9F);
            this.note.Location = new System.Drawing.Point(504, 308);
            this.note.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(226, 92);
            this.note.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("돋움", 9F);
            this.label8.Location = new System.Drawing.Point(418, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 64;
            this.label8.Text = "특이사항";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("돋움", 9F);
            this.label9.Location = new System.Drawing.Point(382, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 65;
            this.label9.Text = "근무 인정 시간";
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("돋움", 9F);
            this.stop.Location = new System.Drawing.Point(504, 256);
            this.stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(226, 25);
            this.stop.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("돋움", 9F);
            this.label4.Location = new System.Drawing.Point(418, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 66;
            this.label4.Text = "퇴근시간";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("돋움", 9F);
            this.start.Location = new System.Drawing.Point(504, 218);
            this.start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(226, 25);
            this.start.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("돋움", 9F);
            this.label5.Location = new System.Drawing.Point(418, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 63;
            this.label5.Text = "출근시간";
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("돋움", 9F);
            this.type.Location = new System.Drawing.Point(504, 175);
            this.type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(226, 25);
            this.type.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("돋움", 9F);
            this.label7.Location = new System.Drawing.Point(418, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 62;
            this.label7.Text = "유형";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(417, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 67);
            this.label1.TabIndex = 61;
            this.label1.Text = "직원 근무 현황";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("돋움", 9F);
            this.monthCalendar1.Location = new System.Drawing.Point(827, 151);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 59;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("돋움", 9F);
            this.label6.Location = new System.Drawing.Point(414, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 65;
            this.label6.Text = "승인 여부";
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("돋움", 9F);
            this.time.Location = new System.Drawing.Point(504, 412);
            this.time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(226, 25);
            this.time.TabIndex = 70;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(286, 488);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 76;
            this.button2.Text = "검색";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pSearch
            // 
            this.pSearch.Location = new System.Drawing.Point(48, 488);
            this.pSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(207, 25);
            this.pSearch.TabIndex = 75;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(48, 151);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(305, 286);
            this.listView1.TabIndex = 77;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "사번";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "부서";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "직급";
            // 
            // empWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 563);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nocheck);
            this.Controls.Add(this.check);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.note);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.time);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "empWork";
            this.Text = "직원 근무 현황";
            this.Load += new System.EventHandler(this.empWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton nocheck;
        private System.Windows.Forms.RadioButton check;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}