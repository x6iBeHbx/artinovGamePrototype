using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePrototypeClient.gameForms;
using GamePrototypeClient.GamePrototypeServiceReference;

namespace GamePrototypeClient.userControls
{
    public partial class Login : UserControl
    {
        public delegate void LoginFormDelegate(UserControl key);

        public EventHandler MyEvent;

        private readonly LoginFormDelegate _loginDelegate;

        public Login(LoginFormDelegate formDelegate)
        {
            InitializeComponent();
            _loginDelegate = formDelegate;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string login = LoginLable.Text;
            string password = PasswordLable.Text;

            using (var clientService = new GamePrototypeServiceClient())
            {
                if (clientService.IsUserLoginDataValid(login, password))
                {
                    //var character = clientService.GetUserByLogin(login).UserCharacter;
                    UserProfile user = clientService.GetUserByLogin(login);
                    var character = clientService.GetCharacterById(user.UserCharacter.Id);
                    Close();
                    _loginDelegate(new MainGameScene(character));
                }
                else
                {
                    MessageBox.Show("Wrong Login/Password");
                }
            }
        }

        private void ToRegisterBtn_Click(object sender, EventArgs e)
        {
            Close();
            _loginDelegate(new Register());
        }

        private void LoginLable_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordLable_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordLable_MouseClick(object sender, MouseEventArgs e)
        {
            PrepareTextBox(PasswordLable);
        }

        private void LoginLable_MouseClick(object sender, MouseEventArgs e)
        {
            PrepareTextBox(LoginLable);
        }

        #region Logic

        private void PrepareTextBox(TextBox lable)
        {
            lable.Clear();
            lable.ForeColor = Color.Black;
        }

        private void IsLableNotEmpty(TextBox lable)
        {
            
        }
        #endregion

        public void Close()
        {
            this.Enabled = false;
            this.Dispose();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminWinForm();
            adminForm.Show();
        }
    }
}
