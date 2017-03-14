using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePrototypeClasses.game.character;
using GamePrototypeClasses.user;

namespace GamePrototypeClient.userControls
{
    public partial class MainGameScene : UserControl
    {
        private Character _characte;
        public MainGameScene(Character character)
        {
            InitializeComponent();

            _characte = character;
            Image image = Image.FromFile(character.ImageUrl);
            CharacterImageBox.Image = image;
            NickName.Text = character.Name;
            CharacterLevel.Text += character.Level;
            CharacterCoins.Text += character.Coins;
            CharacterIntellgence.Text += character.Intelligence;
            CharacterAgility.Text += character.Agility;
            CharacterStrength.Text += character.Attack;
            CharacterHealth.Text += character.Health;
            CharacterMana.Text += character.Mana;
        }

        private void MainGameScene_Load(object sender, EventArgs e)
        {
            
        }

        private void CharacterInfoBtn_Click(object sender, EventArgs e)
        {
            var userInfoScreen = new CharacterPage(_characte);
            Parent.Controls.Add(userInfoScreen);
            this.Dispose();
        }

        private void StoreBtn_Click(object sender, EventArgs e)
        {
            var newScene = new StoreUserControl(_characte);
            Parent.Controls.Add(newScene);
            this.Dispose();
        }
    }
}
