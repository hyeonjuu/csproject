﻿
namespace DBCSProject
{
    partial class jogicdo
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("이사회");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("인천 지점");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("부천 지점");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("서울 지점");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("영업부", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("경리팀");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("지원팀");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("경영지원부", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("시스템 개발팀");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("개발부", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("회사", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode8,
            treeNode11});
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "홍길동",
            "홍길동",
            "팀장",
            "인천 지점"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("김땡땡");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("홍길동");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("홍길동");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("홍길동");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.근태관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.근태현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조직도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.근무정보관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(60, 86);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드15";
            treeNode1.Text = "이사회";
            treeNode2.ImageIndex = -2;
            treeNode2.Name = "노드3";
            treeNode2.Text = "인천 지점";
            treeNode3.Name = "노드4";
            treeNode3.Text = "부천 지점";
            treeNode4.Name = "노드5";
            treeNode4.Text = "서울 지점";
            treeNode5.Name = "노드2";
            treeNode5.Text = "영업부";
            treeNode6.Name = "노드7";
            treeNode6.Text = "경리팀";
            treeNode7.Name = "노드8";
            treeNode7.Text = "지원팀";
            treeNode8.Name = "노드6";
            treeNode8.Text = "경영지원부";
            treeNode9.Name = "노드16";
            treeNode9.Text = "시스템 개발팀";
            treeNode10.Name = "노드17";
            treeNode10.Text = "";
            treeNode11.Name = "노드14";
            treeNode11.Text = "개발부";
            treeNode12.Name = "노드0";
            treeNode12.Text = "회사";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(298, 295);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(60, 405);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(298, 163);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(591, 340);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 28);
            this.textBox4.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "부서";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(591, 273);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 28);
            this.textBox3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "직급";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(934, 274);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(141, 28);
            this.textBox6.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(591, 210);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 28);
            this.textBox2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(829, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "이메일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "이름";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(934, 210);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 28);
            this.textBox5.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(829, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "전화번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(829, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "생일";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(934, 340);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 28);
            this.textBox1.TabIndex = 18;
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
            this.menuStrip1.Size = new System.Drawing.Size(1141, 25);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 근태관리ToolStripMenuItem
            // 
            this.근태관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.근태현황ToolStripMenuItem});
            this.근태관리ToolStripMenuItem.Name = "근태관리ToolStripMenuItem";
            this.근태관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.근태관리ToolStripMenuItem.Text = "근태관리";
            // 
            // 근태현황ToolStripMenuItem
            // 
            this.근태현황ToolStripMenuItem.Name = "근태현황ToolStripMenuItem";
            this.근태현황ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.근태현황ToolStripMenuItem.Text = "근태현황";
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
            this.직원정보수정ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.직원정보수정ToolStripMenuItem.Text = "직원 정보 관리";
            // 
            // 근무정보관리ToolStripMenuItem
            // 
            this.근무정보관리ToolStripMenuItem.Name = "근무정보관리ToolStripMenuItem";
            this.근무정보관리ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.근무정보관리ToolStripMenuItem.Text = "근무 정보 관리";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(60, 592);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(141, 28);
            this.textBox7.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 592);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 30F);
            this.label7.Location = new System.Drawing.Point(703, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 40);
            this.label7.TabIndex = 29;
            this.label7.Text = "조직도";
            // 
            // jogicdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 675);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "jogicdo";
            this.Text = "조직도";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 근태관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 근태현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조직도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원정보수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 근무정보관리ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}