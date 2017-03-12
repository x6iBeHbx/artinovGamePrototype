using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePrototypeClient.userControls;

namespace GamePrototypeClient
{
    public partial class GameForm : Form
    {

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            var loginForm = new Login(OnMyEvent) {AutoScroll = true};
            AddUserControl(loginForm);
            loginForm.Show();
        }

        private void OnMyEvent()
        {
            var mainGameScene = new MainGameScene() { AutoScroll = true };
            AddUserControl(mainGameScene);
            mainGameScene.Show();
        }

        private void AddUserControl(UserControl control)
        {
            this.MainSceneListBox.Controls.Add(control);
        }
    }
}
