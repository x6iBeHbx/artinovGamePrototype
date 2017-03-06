﻿namespace GamePrototypeClient.userControls
{
    partial class MainGameScene
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
            this.CharacterImageBox = new System.Windows.Forms.PictureBox();
            this.CharacterInfoBtn = new System.Windows.Forms.Button();
            this.CharacterHealth = new System.Windows.Forms.Label();
            this.CharacterMana = new System.Windows.Forms.Label();
            this.CharacterStrength = new System.Windows.Forms.Label();
            this.CharacterAgility = new System.Windows.Forms.Label();
            this.CharacterIntellgence = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CharacterImageBox
            // 
            this.CharacterImageBox.Location = new System.Drawing.Point(19, 15);
            this.CharacterImageBox.Name = "CharacterImageBox";
            this.CharacterImageBox.Size = new System.Drawing.Size(109, 172);
            this.CharacterImageBox.TabIndex = 0;
            this.CharacterImageBox.TabStop = false;
            // 
            // CharacterInfoBtn
            // 
            this.CharacterInfoBtn.Location = new System.Drawing.Point(19, 193);
            this.CharacterInfoBtn.Name = "CharacterInfoBtn";
            this.CharacterInfoBtn.Size = new System.Drawing.Size(25, 24);
            this.CharacterInfoBtn.TabIndex = 1;
            this.CharacterInfoBtn.Text = "i";
            this.CharacterInfoBtn.UseVisualStyleBackColor = true;
            // 
            // CharacterHealth
            // 
            this.CharacterHealth.AutoSize = true;
            this.CharacterHealth.Location = new System.Drawing.Point(70, 193);
            this.CharacterHealth.Name = "CharacterHealth";
            this.CharacterHealth.Size = new System.Drawing.Size(41, 13);
            this.CharacterHealth.TabIndex = 7;
            this.CharacterHealth.Text = "Health:";
            // 
            // CharacterMana
            // 
            this.CharacterMana.AutoSize = true;
            this.CharacterMana.Location = new System.Drawing.Point(71, 217);
            this.CharacterMana.Name = "CharacterMana";
            this.CharacterMana.Size = new System.Drawing.Size(37, 13);
            this.CharacterMana.TabIndex = 8;
            this.CharacterMana.Text = "Mana:";
            // 
            // CharacterStrength
            // 
            this.CharacterStrength.AutoSize = true;
            this.CharacterStrength.Location = new System.Drawing.Point(134, 15);
            this.CharacterStrength.Name = "CharacterStrength";
            this.CharacterStrength.Size = new System.Drawing.Size(53, 13);
            this.CharacterStrength.TabIndex = 9;
            this.CharacterStrength.Text = "Strength: ";
            // 
            // CharacterAgility
            // 
            this.CharacterAgility.AutoSize = true;
            this.CharacterAgility.Location = new System.Drawing.Point(134, 39);
            this.CharacterAgility.Name = "CharacterAgility";
            this.CharacterAgility.Size = new System.Drawing.Size(37, 13);
            this.CharacterAgility.TabIndex = 10;
            this.CharacterAgility.Text = "Agility:";
            // 
            // CharacterIntellgence
            // 
            this.CharacterIntellgence.AutoSize = true;
            this.CharacterIntellgence.Location = new System.Drawing.Point(134, 66);
            this.CharacterIntellgence.Name = "CharacterIntellgence";
            this.CharacterIntellgence.Size = new System.Drawing.Size(64, 13);
            this.CharacterIntellgence.TabIndex = 11;
            this.CharacterIntellgence.Text = "Intelligence:";
            // 
            // MainGameScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CharacterIntellgence);
            this.Controls.Add(this.CharacterAgility);
            this.Controls.Add(this.CharacterStrength);
            this.Controls.Add(this.CharacterMana);
            this.Controls.Add(this.CharacterHealth);
            this.Controls.Add(this.CharacterInfoBtn);
            this.Controls.Add(this.CharacterImageBox);
            this.Name = "MainGameScene";
            this.Size = new System.Drawing.Size(714, 353);
            this.Load += new System.EventHandler(this.MainGameScene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CharacterImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CharacterImageBox;
        private System.Windows.Forms.Button CharacterInfoBtn;
        private System.Windows.Forms.Label CharacterHealth;
        private System.Windows.Forms.Label CharacterMana;
        private System.Windows.Forms.Label CharacterStrength;
        private System.Windows.Forms.Label CharacterAgility;
        private System.Windows.Forms.Label CharacterIntellgence;
    }
}
