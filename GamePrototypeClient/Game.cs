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
            var loginForm = new Login();
            //loginForm.Width = this.MainSceneListBox.Width;
            //loginForm.Height = this.MainSceneListBox.Height;
            loginForm.AutoScroll = true;
            this.MainSceneListBox.Controls.Add(loginForm);
            loginForm.Show();
            
        }
    }
}
