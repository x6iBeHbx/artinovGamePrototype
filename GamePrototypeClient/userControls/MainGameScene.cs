using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePrototypeClient.userControls
{
    public partial class MainGameScene : UserControl
    {
        public MainGameScene()
        {
            InitializeComponent();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void MainGameScene_Load(object sender, EventArgs e)
        {

        }

        private void CharacterInfoBtn_Click(object sender, EventArgs e)
        {
            var userInfoScreen = new CharacterPage();
            this.Controls.Add(userInfoScreen);
        }
    }
}
