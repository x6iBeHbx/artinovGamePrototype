namespace GamePrototypeClient.gameForms
{
    partial class AdminWinForm
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
            this.AdminSplitContainer = new System.Windows.Forms.SplitContainer();
            this.AdminTopPanel = new System.Windows.Forms.MenuStrip();
            this.ThingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.AdminSplitContainer)).BeginInit();
            this.AdminSplitContainer.Panel1.SuspendLayout();
            this.AdminSplitContainer.SuspendLayout();
            this.AdminTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminSplitContainer
            // 
            this.AdminSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.AdminSplitContainer.Name = "AdminSplitContainer";
            this.AdminSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // AdminSplitContainer.Panel1
            // 
            this.AdminSplitContainer.Panel1.Controls.Add(this.AdminTopPanel);
            this.AdminSplitContainer.Size = new System.Drawing.Size(638, 371);
            this.AdminSplitContainer.SplitterDistance = 33;
            this.AdminSplitContainer.TabIndex = 0;
            // 
            // AdminTopPanel
            // 
            this.AdminTopPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThingsMenu});
            this.AdminTopPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminTopPanel.Name = "AdminTopPanel";
            this.AdminTopPanel.Size = new System.Drawing.Size(638, 24);
            this.AdminTopPanel.TabIndex = 0;
            this.AdminTopPanel.Text = "AdminTopPanel";
            // 
            // ThingsMenu
            // 
            this.ThingsMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ThingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItem,
            this.DeleteItem,
            this.UpdateItem});
            this.ThingsMenu.Name = "ThingsMenu";
            this.ThingsMenu.Size = new System.Drawing.Size(55, 20);
            this.ThingsMenu.Text = "Things";
            // 
            // AddItem
            // 
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(152, 22);
            this.AddItem.Text = "Add";
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteItem.Text = "Delete";
            // 
            // UpdateItem
            // 
            this.UpdateItem.Name = "UpdateItem";
            this.UpdateItem.Size = new System.Drawing.Size(152, 22);
            this.UpdateItem.Text = "Update";
            this.UpdateItem.Click += new System.EventHandler(this.UpdateItem_Click);
            // 
            // AdminWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 371);
            this.Controls.Add(this.AdminSplitContainer);
            this.MainMenuStrip = this.AdminTopPanel;
            this.Name = "AdminWinForm";
            this.Text = "AdminWinForm";
            this.AdminSplitContainer.Panel1.ResumeLayout(false);
            this.AdminSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminSplitContainer)).EndInit();
            this.AdminSplitContainer.ResumeLayout(false);
            this.AdminTopPanel.ResumeLayout(false);
            this.AdminTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer AdminSplitContainer;
        private System.Windows.Forms.MenuStrip AdminTopPanel;
        private System.Windows.Forms.ToolStripMenuItem ThingsMenu;
        private System.Windows.Forms.ToolStripMenuItem AddItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateItem;
    }
}