﻿namespace GamePrototypeClient.userControls
{
    partial class StoreUserControl
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
            this.ThingsList = new System.Windows.Forms.ListView();
            this.BackBtn = new System.Windows.Forms.Button();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BalanceLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThingsList
            // 
            this.ThingsList.Location = new System.Drawing.Point(4, 4);
            this.ThingsList.Name = "ThingsList";
            this.ThingsList.Size = new System.Drawing.Size(418, 307);
            this.ThingsList.TabIndex = 0;
            this.ThingsList.UseCompatibleStateImageBehavior = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(465, 288);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            // 
            // BuyBtn
            // 
            this.BuyBtn.Location = new System.Drawing.Point(465, 230);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(75, 23);
            this.BuyBtn.TabIndex = 2;
            this.BuyBtn.Text = "Buy";
            this.BuyBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Balance";
            // 
            // BalanceLable
            // 
            this.BalanceLable.AutoSize = true;
            this.BalanceLable.Location = new System.Drawing.Point(468, 31);
            this.BalanceLable.Name = "BalanceLable";
            this.BalanceLable.Size = new System.Drawing.Size(25, 13);
            this.BalanceLable.TabIndex = 4;
            this.BalanceLable.Text = "999";
            this.BalanceLable.Click += new System.EventHandler(this.BalanceLable_Click);
            // 
            // StoreUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BalanceLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ThingsList);
            this.Name = "StoreUserControl";
            this.Size = new System.Drawing.Size(573, 314);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ThingsList;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BalanceLable;
    }
}
