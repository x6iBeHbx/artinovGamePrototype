using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePrototypeClient.GamePrototypeServiceReference;

namespace GamePrototypeClient.userControls
{
    public partial class Login : UserControl
    {
        public delegate void LoginFormDelegate();

        public EventHandler MyEvent;

        private readonly LoginFormDelegate _callBackDelegate;

        public Login(LoginFormDelegate formDelegate)
        {
            InitializeComponent();
            _callBackDelegate = formDelegate;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string login = LoginLable.Text;
            string password = PasswordLable.Text;

            using (var clientService = new GamePrototypeServiceClient())
            {
                if (clientService.IsUserLoginDataValid(login, password))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Wrong Login/Password");
                }
            }
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
            _callBackDelegate();
            this.Enabled = false;
            this.Dispose();
        }
    }
}
