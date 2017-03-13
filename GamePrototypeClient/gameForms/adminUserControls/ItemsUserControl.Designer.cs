namespace GamePrototypeClient.gameForms.adminUserControls
{
    partial class ItemsUserControl
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
            this.ItemsList = new System.Windows.Forms.ListView();
            this.ColumnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHealth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnMana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAttack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnMagicAttack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDefence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnMagicDefence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAgility = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnIntelligence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnImgUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCoins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnThingType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnSpecialBonus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ItemsList
            // 
            this.ItemsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnLevel,
            this.ColumnHealth,
            this.ColumnMana,
            this.ColumnAttack,
            this.ColumnMagicAttack,
            this.ColumnDefence,
            this.ColumnMagicDefence,
            this.ColumnAgility,
            this.ColumnIntelligence,
            this.ColumnImgUrl,
            this.ColumnCoins,
            this.ColumnThingType,
            this.ColumnSpecialBonus});
            this.ItemsList.GridLines = true;
            this.ItemsList.Location = new System.Drawing.Point(3, 7);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(736, 285);
            this.ItemsList.TabIndex = 0;
            this.ItemsList.UseCompatibleStateImageBehavior = false;
            this.ItemsList.View = System.Windows.Forms.View.Details;
            this.ItemsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ItemsList_MouseDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.Text = "Id";
            this.ColumnId.Width = 25;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 109;
            // 
            // ColumnLevel
            // 
            this.ColumnLevel.Text = "Lvl";
            this.ColumnLevel.Width = 35;
            // 
            // ColumnHealth
            // 
            this.ColumnHealth.Text = "Health";
            this.ColumnHealth.Width = 47;
            // 
            // ColumnMana
            // 
            this.ColumnMana.Text = "Mana";
            this.ColumnMana.Width = 41;
            // 
            // ColumnAttack
            // 
            this.ColumnAttack.Text = "Atk";
            this.ColumnAttack.Width = 38;
            // 
            // ColumnMagicAttack
            // 
            this.ColumnMagicAttack.Text = "MAtk";
            this.ColumnMagicAttack.Width = 38;
            // 
            // ColumnDefence
            // 
            this.ColumnDefence.Text = "Def";
            this.ColumnDefence.Width = 37;
            // 
            // ColumnMagicDefence
            // 
            this.ColumnMagicDefence.Text = "MDef";
            this.ColumnMagicDefence.Width = 41;
            // 
            // ColumnAgility
            // 
            this.ColumnAgility.Text = "Aglt";
            this.ColumnAgility.Width = 39;
            // 
            // ColumnIntelligence
            // 
            this.ColumnIntelligence.Text = "Int";
            this.ColumnIntelligence.Width = 30;
            // 
            // ColumnImgUrl
            // 
            this.ColumnImgUrl.Text = "ImgUrl";
            // 
            // ColumnCoins
            // 
            this.ColumnCoins.Text = "Coins";
            this.ColumnCoins.Width = 50;
            // 
            // ColumnThingType
            // 
            this.ColumnThingType.Text = "Type";
            this.ColumnThingType.Width = 45;
            // 
            // ColumnSpecialBonus
            // 
            this.ColumnSpecialBonus.Text = "SpecBonus";
            this.ColumnSpecialBonus.Width = 89;
            // 
            // ItemsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsList);
            this.Name = "ItemsUserControl";
            this.Size = new System.Drawing.Size(781, 310);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView ItemsList;
        private System.Windows.Forms.ColumnHeader ColumnId;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.ColumnHeader ColumnLevel;
        private System.Windows.Forms.ColumnHeader ColumnHealth;
        private System.Windows.Forms.ColumnHeader ColumnMana;
        private System.Windows.Forms.ColumnHeader ColumnAttack;
        private System.Windows.Forms.ColumnHeader ColumnMagicAttack;
        private System.Windows.Forms.ColumnHeader ColumnDefence;
        private System.Windows.Forms.ColumnHeader ColumnMagicDefence;
        private System.Windows.Forms.ColumnHeader ColumnAgility;
        private System.Windows.Forms.ColumnHeader ColumnIntelligence;
        private System.Windows.Forms.ColumnHeader ColumnImgUrl;
        private System.Windows.Forms.ColumnHeader ColumnCoins;
        private System.Windows.Forms.ColumnHeader ColumnThingType;
        private System.Windows.Forms.ColumnHeader ColumnSpecialBonus;
    }
}
