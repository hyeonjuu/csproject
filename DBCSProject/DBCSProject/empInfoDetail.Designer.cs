
namespace DBCSProject
{
    partial class EMPDetail
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.pDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pVacation = new System.Windows.Forms.TextBox();
            this.pBirth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pWorking = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.직원검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView1.Location = new System.Drawing.Point(75, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(736, 274);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.saveBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(705, 481);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(106, 52);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "저장";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.searchBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(705, 401);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(106, 54);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "검색";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // pDate
            // 
            this.pDate.Location = new System.Drawing.Point(496, 510);
            this.pDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pDate.Name = "pDate";
            this.pDate.Size = new System.Drawing.Size(151, 25);
            this.pDate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(366, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "입사일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(72, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "고용형태";
            // 
            // pVacation
            // 
            this.pVacation.Location = new System.Drawing.Point(496, 455);
            this.pVacation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pVacation.Name = "pVacation";
            this.pVacation.Size = new System.Drawing.Size(151, 25);
            this.pVacation.TabIndex = 17;
            // 
            // pBirth
            // 
            this.pBirth.Location = new System.Drawing.Point(174, 455);
            this.pBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBirth.Name = "pBirth";
            this.pBirth.Size = new System.Drawing.Size(151, 25);
            this.pBirth.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(366, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "연간 연차시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(72, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "생년월일";
            // 
            // pWorking
            // 
            this.pWorking.Location = new System.Drawing.Point(496, 401);
            this.pWorking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pWorking.Name = "pWorking";
            this.pWorking.Size = new System.Drawing.Size(151, 25);
            this.pWorking.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(366, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "주 근무시간";
            // 
            // pNo
            // 
            this.pNo.Location = new System.Drawing.Point(174, 401);
            this.pNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pNo.Name = "pNo";
            this.pNo.ReadOnly = true;
            this.pNo.Size = new System.Drawing.Size(151, 25);
            this.pNo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(72, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "사번";
            // 
            // pType
            // 
            this.pType.FormattingEnabled = true;
            this.pType.Items.AddRange(new object[] {
            "정규직",
            "계약직",
            "아르바이트"});
            this.pType.Location = new System.Drawing.Point(174, 511);
            this.pType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pType.Name = "pType";
            this.pType.Size = new System.Drawing.Size(151, 23);
            this.pType.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.label4.Location = new System.Drawing.Point(224, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(483, 67);
            this.label4.TabIndex = 29;
            this.label4.Text = "직원 부가 정보 관리";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.직원검색ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // 직원검색ToolStripMenuItem
            // 
            this.직원검색ToolStripMenuItem.Name = "직원검색ToolStripMenuItem";
            this.직원검색ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.직원검색ToolStripMenuItem.Text = "직원 검색";
            this.직원검색ToolStripMenuItem.Click += new System.EventHandler(this.직원검색ToolStripMenuItem_Click);
            // 
            // EMPDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pType);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.pDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pVacation);
            this.Controls.Add(this.pBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pWorking);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EMPDetail";
            this.Text = "직원 부가 정보 관리";
            this.Load += new System.EventHandler(this.EMPDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox pDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pVacation;
        private System.Windows.Forms.TextBox pBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pWorking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 직원검색ToolStripMenuItem;
    }
}