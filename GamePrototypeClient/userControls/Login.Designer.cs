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
            this.LoginLable = new System.Windows.Forms.TextBox();
            this.PasswordLable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToRegisterBtn = new System.Windows.Forms.Button();
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
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginLable
            // 
            this.LoginLable.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LoginLable.Location = new System.Drawing.Point(253, 103);
            this.LoginLable.MaxLength = 500;
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(221, 20);
            this.LoginLable.TabIndex = 1;
            this.LoginLable.Text = "Login";
            this.LoginLable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginLable_MouseClick);
            this.LoginLable.TextChanged += new System.EventHandler(this.LoginLable_TextChanged);
            // 
            // PasswordLable
            // 
            this.PasswordLable.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordLable.Location = new System.Drawing.Point(253, 137);
            this.PasswordLable.MaxLength = 500;
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(221, 20);
            this.PasswordLable.TabIndex = 2;
            this.PasswordLable.Text = "Password";
            this.PasswordLable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PasswordLable_MouseClick);
            this.PasswordLable.TextChanged += new System.EventHandler(this.PasswordLable_TextChanged);
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
            // ToRegisterBtn
            // 
            this.ToRegisterBtn.Location = new System.Drawing.Point(322, 228);
            this.ToRegisterBtn.Name = "ToRegisterBtn";
            this.ToRegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.ToRegisterBtn.TabIndex = 4;
            this.ToRegisterBtn.Text = "Register";
            this.ToRegisterBtn.UseVisualStyleBackColor = true;
            this.ToRegisterBtn.Click += new System.EventHandler(this.ToRegisterBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ToRegisterBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.LoginLable);
            this.Controls.Add(this.LoginBtn);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(720, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox LoginLable;
        private System.Windows.Forms.TextBox PasswordLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToRegisterBtn;
    }
}
