namespace GamePrototypeClient
{
    partial class GameForm
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
            this.MainSceneListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MainSceneListBox
            // 
            this.MainSceneListBox.FormattingEnabled = true;
            this.MainSceneListBox.Location = new System.Drawing.Point(-5, -13);
            this.MainSceneListBox.Name = "MainSceneListBox";
            this.MainSceneListBox.Size = new System.Drawing.Size(720, 355);
            this.MainSceneListBox.TabIndex = 0;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 344);
            this.Controls.Add(this.MainSceneListBox);
            this.Name = "GameForm";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MainSceneListBox;
    }
}

