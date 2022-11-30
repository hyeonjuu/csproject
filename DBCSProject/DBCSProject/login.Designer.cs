
namespace DBCSProject
{
    partial class login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.id = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id.Location = new System.Drawing.Point(384, 123);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(181, 21);
            this.id.TabIndex = 1;
            this.id.Text = "아이디";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.password.Location = new System.Drawing.Point(384, 176);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(181, 21);
            this.password.TabIndex = 2;
            this.password.Text = "비밀번호";
            this.password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(22, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "개발혁동조합";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.loginBtn.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(384, 238);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(181, 47);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "로그인";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 367);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
    }
}

