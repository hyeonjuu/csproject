﻿
namespace DBCSProject
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.근태관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내근무현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.휴가신청ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조직도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원근태현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원휴가승인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.근태관리ToolStripMenuItem,
            this.조직도ToolStripMenuItem,
            this.직원관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 근태관리ToolStripMenuItem
            // 
            this.근태관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.내근무현황ToolStripMenuItem,
            this.휴가신청ToolStripMenuItem});
            this.근태관리ToolStripMenuItem.Name = "근태관리ToolStripMenuItem";
            this.근태관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.근태관리ToolStripMenuItem.Text = "근태 관리";
            // 
            // 내근무현황ToolStripMenuItem
            // 
            this.내근무현황ToolStripMenuItem.Name = "내근무현황ToolStripMenuItem";
            this.내근무현황ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.내근무현황ToolStripMenuItem.Text = "내 근무 현황";
            // 
            // 휴가신청ToolStripMenuItem
            // 
            this.휴가신청ToolStripMenuItem.Name = "휴가신청ToolStripMenuItem";
            this.휴가신청ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.휴가신청ToolStripMenuItem.Text = "휴가 신청";
            // 
            // 조직도ToolStripMenuItem
            // 
            this.조직도ToolStripMenuItem.Name = "조직도ToolStripMenuItem";
            this.조직도ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.조직도ToolStripMenuItem.Text = "조직도";
            this.조직도ToolStripMenuItem.Click += new System.EventHandler(this.조직도ToolStripMenuItem_Click);
            // 
            // 직원관리ToolStripMenuItem
            // 
            this.직원관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.직원근태현황ToolStripMenuItem,
            this.직원휴가승인ToolStripMenuItem,
            this.직원정보수정ToolStripMenuItem});
            this.직원관리ToolStripMenuItem.Name = "직원관리ToolStripMenuItem";
            this.직원관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.직원관리ToolStripMenuItem.Text = "직원 관리";
            // 
            // 직원근태현황ToolStripMenuItem
            // 
            this.직원근태현황ToolStripMenuItem.Name = "직원근태현황ToolStripMenuItem";
            this.직원근태현황ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.직원근태현황ToolStripMenuItem.Text = "근태 현황";
            // 
            // 직원휴가승인ToolStripMenuItem
            // 
            this.직원휴가승인ToolStripMenuItem.Name = "직원휴가승인ToolStripMenuItem";
            this.직원휴가승인ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.직원휴가승인ToolStripMenuItem.Text = "휴가 승인";
            // 
            // 직원정보수정ToolStripMenuItem
            // 
            this.직원정보수정ToolStripMenuItem.Name = "직원정보수정ToolStripMenuItem";
            this.직원정보수정ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.직원정보수정ToolStripMenuItem.Text = "직원 정보 수정";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 552);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 근태관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 내근무현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 휴가신청ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조직도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원근태현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원휴가승인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원정보수정ToolStripMenuItem;
    }
}