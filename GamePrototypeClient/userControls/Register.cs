using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePrototypeClasses.enums;

namespace GamePrototypeClient.userControls
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
            initRegistrationBoxes();
        }

        private void HeroesTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region init

        private void initRegistrationBoxes()
        {
            //init hearoes types
            HeroesTypeComboBox.Text = CharacterTypeEnum.Warrior.ToString();
            HeroesTypeComboBox.Items.Add(CharacterTypeEnum.Warrior);
            HeroesTypeComboBox.Items.Add(CharacterTypeEnum.Assassin);
            HeroesTypeComboBox.Items.Add(CharacterTypeEnum.Wizard);

            //init sex types
            SexComboBox.Text = UserSexEnum.Male.ToString();
            SexComboBox.Items.Add(UserSexEnum.Male);
            SexComboBox.Items.Add(UserSexEnum.Female);
        }
        #endregion

        private void LoadCharacterImgBtn_Click(object sender, EventArgs e)
        {
            using (var loadDialog = new OpenFileDialog())
            {
                loadDialog.ShowDialog();
                Bitmap img = (Bitmap) Image.FromFile(loadDialog.FileName);
                CharacterImage.Image = img;
            }
        }
    }
}
