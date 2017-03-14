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

namespace GamePrototypeClient.userControls
{
    public partial class CharacterPage : UserControl
    {
        private Character _character;
        public CharacterPage(Character character)
        {
            InitializeComponent();
            Image image = Image.FromFile(character.ImageUrl);
            CharaterImg.Image = image;
            _character = character;
        }

        private void ToMainScene_Click(object sender, EventArgs e)
        {
            var mainGameScene = new MainGameScene(_character);
            Parent.Controls.Add(mainGameScene);
            this.Dispose();
        }
    }
}
