
namespace DBCSProject
{
    partial class main
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
            this.today = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.note = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.currentLabel = new System.Windows.Forms.Label();
            this.planLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WSCurrent = new System.Windows.Forms.Label();
            this.WSPlan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // today
            // 
            this.today.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.today.Location = new System.Drawing.Point(29, 135);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(342, 76);
            this.today.TabIndex = 1;
            this.today.Text = "2022년 11월 1일";
            this.today.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("돋움", 30F);
            this.button1.Location = new System.Drawing.Point(50, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "출근";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // note
            // 
            this.note.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.note.Location = new System.Drawing.Point(50, 295);
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(320, 45);
            this.note.TabIndex = 3;
            this.note.Text = "특이사항";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(447, 187);
            this.progressBar1.Maximum = 160;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(276, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 30;
            // 
            // currentLabel
            // 
            this.currentLabel.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.currentLabel.Location = new System.Drawing.Point(434, 128);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(136, 19);
            this.currentLabel.TabIndex = 5;
            this.currentLabel.Text = "이달의 현재 근무시간\r\n";
            // 
            // planLabel
            // 
            this.planLabel.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.planLabel.Location = new System.Drawing.Point(610, 125);
            this.planLabel.Name = "planLabel";
            this.planLabel.Size = new System.Drawing.Size(122, 19);
            this.planLabel.TabIndex = 5;
            this.planLabel.Text = "이달의 총 근무시간\r\n";
            this.planLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(530, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "내 휴가 통계";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(421, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(344, 151);
            this.dataGridView1.TabIndex = 8;
            // 
            // empInfo
            // 
            this.empInfo.Font = new System.Drawing.Font("돋움", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empInfo.Location = new System.Drawing.Point(43, 67);
            this.empInfo.Name = "empInfo";
            this.empInfo.Size = new System.Drawing.Size(328, 48);
            this.empInfo.TabIndex = 1;
            this.empInfo.Text = "사원 : 조현주";
            this.empInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "이달의 근무";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("돋움", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.status.Location = new System.Drawing.Point(43, 225);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(328, 57);
            this.status.TabIndex = 1;
            this.status.Text = "출근 전";
            this.status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WSCurrent
            // 
            this.WSCurrent.Font = new System.Drawing.Font("돋움", 15F);
            this.WSCurrent.Location = new System.Drawing.Point(437, 147);
            this.WSCurrent.Name = "WSCurrent";
            this.WSCurrent.Size = new System.Drawing.Size(133, 19);
            this.WSCurrent.TabIndex = 5;
            this.WSCurrent.Text = "0h";
            this.WSCurrent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WSPlan
            // 
            this.WSPlan.Font = new System.Drawing.Font("돋움", 15F);
            this.WSPlan.Location = new System.Drawing.Point(613, 147);
            this.WSPlan.Name = "WSPlan";
            this.WSPlan.Size = new System.Drawing.Size(119, 19);
            this.WSPlan.TabIndex = 5;
            this.WSPlan.Text = "0h";
            this.WSPlan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(421, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 155);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(811, 499);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.planLabel);
            this.Controls.Add(this.WSPlan);
            this.Controls.Add(this.WSCurrent);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.note);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.empInfo);
            this.Controls.Add(this.status);
            this.Controls.Add(this.today);
            this.Controls.Add(this.groupBox1);
            this.Name = "main";
            this.Text = "출퇴근하기";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label today;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label planLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label empInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label WSCurrent;
        private System.Windows.Forms.Label WSPlan;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}