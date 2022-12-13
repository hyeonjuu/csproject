
namespace DBCSProject
{
    partial class organizationChart
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("이사회");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("인천 지점");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("부천 지점");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("서울 지점");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("영업부", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("경리팀");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("지원팀");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("경영지원부", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("시스템팀");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("모바일팀");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("개발부", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("회사", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode17,
            treeNode20,
            treeNode23});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pRank = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pEmail = new System.Windows.Forms.TextBox();
            this.pTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView1.Location = new System.Drawing.Point(32, 65);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "노드15";
            treeNode13.Tag = "ES000";
            treeNode13.Text = "이사회";
            treeNode14.ImageIndex = -2;
            treeNode14.Name = "노드3";
            treeNode14.Tag = "MK010";
            treeNode14.Text = "인천 지점";
            treeNode15.Name = "노드4";
            treeNode15.Tag = "MK011";
            treeNode15.Text = "부천 지점";
            treeNode16.Name = "노드5";
            treeNode16.Tag = "MK012";
            treeNode16.Text = "서울 지점";
            treeNode17.Name = "노드2";
            treeNode17.Tag = "MK000";
            treeNode17.Text = "영업부";
            treeNode18.Name = "노드7";
            treeNode18.Tag = "BS010";
            treeNode18.Text = "경리팀";
            treeNode19.Name = "노드8";
            treeNode19.Tag = "BS011";
            treeNode19.Text = "지원팀";
            treeNode20.Name = "노드6";
            treeNode20.Tag = "BS000";
            treeNode20.Text = "경영지원부";
            treeNode21.Name = "노드5";
            treeNode21.Tag = "DEV010";
            treeNode21.Text = "시스템팀";
            treeNode22.Name = "노드6";
            treeNode22.Tag = "DEV011";
            treeNode22.Text = "모바일팀";
            treeNode23.Name = "노드14";
            treeNode23.Tag = "DEV000";
            treeNode23.Text = "개발부";
            treeNode24.Name = "노드0";
            treeNode24.Tag = "개발혁동조합";
            treeNode24.Text = "회사";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(354, 246);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pDepartment
            // 
            this.pDepartment.Font = new System.Drawing.Font("돋움", 10F);
            this.pDepartment.Location = new System.Drawing.Point(645, 294);
            this.pDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDepartment.Name = "pDepartment";
            this.pDepartment.Size = new System.Drawing.Size(155, 27);
            this.pDepartment.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label4.Location = new System.Drawing.Point(466, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "부서";
            // 
            // pRank
            // 
            this.pRank.Font = new System.Drawing.Font("돋움", 10F);
            this.pRank.Location = new System.Drawing.Point(645, 228);
            this.pRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pRank.Name = "pRank";
            this.pRank.Size = new System.Drawing.Size(155, 27);
            this.pRank.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label3.Location = new System.Drawing.Point(466, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "직급";
            // 
            // pEmail
            // 
            this.pEmail.Font = new System.Drawing.Font("돋움", 10F);
            this.pEmail.Location = new System.Drawing.Point(645, 425);
            this.pEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(155, 27);
            this.pEmail.TabIndex = 16;
            // 
            // pTel
            // 
            this.pTel.Font = new System.Drawing.Font("돋움", 10F);
            this.pTel.Location = new System.Drawing.Point(645, 361);
            this.pTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pTel.Name = "pTel";
            this.pTel.Size = new System.Drawing.Size(155, 27);
            this.pTel.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label6.Location = new System.Drawing.Point(466, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "이메일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label2.Location = new System.Drawing.Point(466, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "이름";
            // 
            // pName
            // 
            this.pName.Font = new System.Drawing.Font("돋움", 10F);
            this.pName.Location = new System.Drawing.Point(645, 166);
            this.pName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(155, 27);
            this.pName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label5.Location = new System.Drawing.Point(466, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "전화번호";
            // 
            // pSearch
            // 
            this.pSearch.Location = new System.Drawing.Point(32, 492);
            this.pSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(207, 25);
            this.pSearch.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(293, 492);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.label7.Location = new System.Drawing.Point(546, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 67);
            this.label7.TabIndex = 29;
            this.label7.Text = "조직도";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 338);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(354, 135);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // organizationChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 562);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pSearch);
            this.Controls.Add(this.pDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pRank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pEmail);
            this.Controls.Add(this.pTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.treeView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "organizationChart";
            this.Text = "조직도";
            this.Load += new System.EventHandler(this.organizationChart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox pDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pRank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pEmail;
        private System.Windows.Forms.TextBox pTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}