namespace GamePrototypeClient.userControls
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginBtn = new System.Windows.Forms.Button();
            this.loginLable = new System.Windows.Forms.TextBox();
            this.passwordLable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(322, 173);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Start";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // loginLable
            // 
            this.loginLable.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.loginLable.Location = new System.Drawing.Point(253, 103);
            this.loginLable.MaxLength = 500;
            this.loginLable.Name = "loginLable";
            this.loginLable.Size = new System.Drawing.Size(221, 20);
            this.loginLable.TabIndex = 1;
            this.loginLable.Text = "Login";
            // 
            // passwordLable
            // 
            this.passwordLable.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordLable.Location = new System.Drawing.Point(253, 137);
            this.passwordLable.MaxLength = 500;
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(221, 20);
            this.passwordLable.TabIndex = 2;
            this.passwordLable.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(232, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Some Game Prototype ";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(322, 315);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLable);
            this.Controls.Add(this.loginLable);
            this.Controls.Add(this.LoginBtn);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(720, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox loginLable;
        private System.Windows.Forms.TextBox passwordLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerBtn;
    }
}
