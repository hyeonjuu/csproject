
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
            this.label1 = new System.Windows.Forms.Label();
            this.pNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pRank = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pDepartment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pStatus = new System.Windows.Forms.TextBox();
            this.appendBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.empdetailBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(745, 219);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(47, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "사번";
            // 
            // pNo
            // 
            this.pNo.Location = new System.Drawing.Point(95, 340);
            this.pNo.Name = "pNo";
            this.pNo.Size = new System.Drawing.Size(145, 21);
            this.pNo.TabIndex = 3;
            this.pNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(47, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름";
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(95, 383);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(145, 21);
            this.pName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(47, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "직급";
            // 
            // pRank
            // 
            this.pRank.Location = new System.Drawing.Point(95, 425);
            this.pRank.Name = "pRank";
            this.pRank.Size = new System.Drawing.Size(145, 21);
            this.pRank.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(47, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "부서";
            // 
            // pDepartment
            // 
            this.pDepartment.Location = new System.Drawing.Point(95, 470);
            this.pDepartment.Name = "pDepartment";
            this.pDepartment.Size = new System.Drawing.Size(145, 21);
            this.pDepartment.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(324, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "전화번호";
            // 
            // pTel
            // 
            this.pTel.Location = new System.Drawing.Point(406, 340);
            this.pTel.Name = "pTel";
            this.pTel.Size = new System.Drawing.Size(154, 21);
            this.pTel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(324, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "이메일";
            // 
            // pEmail
            // 
            this.pEmail.Location = new System.Drawing.Point(406, 383);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(154, 21);
            this.pEmail.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(324, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "상태";
            // 
            // pStatus
            // 
            this.pStatus.Location = new System.Drawing.Point(406, 425);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(154, 21);
            this.pStatus.TabIndex = 3;
            // 
            // appendBtn
            // 
            this.appendBtn.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.appendBtn.Location = new System.Drawing.Point(634, 386);
            this.appendBtn.Name = "appendBtn";
            this.appendBtn.Size = new System.Drawing.Size(161, 23);
            this.appendBtn.TabIndex = 4;
            this.appendBtn.Text = "추가";
            this.appendBtn.UseVisualStyleBackColor = true;
            this.appendBtn.Click += new System.EventHandler(this.appendBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updateBtn.Location = new System.Drawing.Point(634, 430);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(161, 23);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "수정";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchBtn.Location = new System.Drawing.Point(634, 343);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(161, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "검색";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // empdetailBtn
            // 
            this.empdetailBtn.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.empdetailBtn.Location = new System.Drawing.Point(634, 468);
            this.empdetailBtn.Name = "empdetailBtn";
            this.empdetailBtn.Size = new System.Drawing.Size(161, 35);
            this.empdetailBtn.TabIndex = 4;
            this.empdetailBtn.Text = "부가정보 보기";
            this.empdetailBtn.UseVisualStyleBackColor = true;
            this.empdetailBtn.Click += new System.EventHandler(this.empdetailBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("돋움", 30F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.label9.Location = new System.Drawing.Point(269, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 40);
            this.label9.TabIndex = 29;
            this.label9.Text = "직원 정보 관리";
            // 
            // changeEMPInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(841, 530);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.empdetailBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.appendBtn);
            this.Controls.Add(this.pDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pStatus);
            this.Controls.Add(this.pRank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pEmail);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "changeEMPInfo";
            this.Text = "직원 정보 관리";
            this.Load += new System.EventHandler(this.changeEMPInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pRank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pStatus;
        private System.Windows.Forms.Button appendBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button empdetailBtn;
        private System.Windows.Forms.Label label9;
    }
}