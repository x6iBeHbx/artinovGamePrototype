using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePrototypeClasses.enums;
using GamePrototypeClasses.game.character;
using GamePrototypeClasses.game.character.warehouse;
using GamePrototypeClasses.user;
using GamePrototypeClient.GamePrototypeServiceReference;

namespace GamePrototypeClient.userControls
{
    
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
            initRegistrationBoxes();
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

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (!IsAllBoxesFilled)
            {
                MessageBox.Show("Plaese fill all text field!!!");
            }
            else if (!IsEmaiValid(EmailBox.Text))
            {
                MessageBox.Show("Plaese write correct Email !!!");
            }
            else
            {
                CreateUserData();
            }
        }

        private void CreateUserData()
        {
            using (var clientService = new GamePrototypeServiceClient())
            {
                clientService.SetUserProfile(CreateUserProfile());
            }
        }

        private Character CreateUserCharacter()
        {
            var character = new Character();
            character.Name = NicknameBox.Text;
            character.CharacterType = (CharacterTypeEnum) ((HeroesTypeComboBox.SelectedIndex == -1) ? HeroesTypeComboBox.Items[0] : HeroesTypeComboBox.Items[HeroesTypeComboBox.SelectedIndex]);
            character.CharacterWarehouse = new CharacterWarehouse();
            character.CharacterEquipment = new CharacterEquipment();

            //TODO: need create logic for generate directory and save in it image;
            var a = CharacterImage.Name;
            character.ImageUrl = "https://www.stihi.ru/pics/2010/11/18/3439.jpg";
            //TODO: need get from DB parameters for herouse or do it on server side
            character.Health = 100;
            character.Mana = 50;
            character.Attack = 10;
            character.MagicAttack = 2;
            character.Defense = 20;
            character.MagicDefence = 5;
            character.Agility = 5;
            character.Intelligence = 5;
            character.Coins = 500;

            character.Level = 1;

            return character;
        }

        private UserProfile CreateUserProfile()
        {
            var userProfile = new UserProfile();
            userProfile.Login = LoginBox.Text;
            userProfile.Password = PassBox1.Text;
            userProfile.Name = FirstNameBox.Text;
            userProfile.LastName = LastNameBox.Text;
            userProfile.EMail = EmailBox.Text;
            userProfile.PhoneNumber = PhoneBox.Text;
            userProfile.Age = Int32.Parse(AgeBox.Text);
            userProfile.UserSex = (UserSexEnum)((SexComboBox.SelectedIndex == -1) ? SexComboBox.Items[0] : SexComboBox.Items[SexComboBox.SelectedIndex]);

            userProfile.UserCharacter = CreateUserCharacter();

            return userProfile;
        }


    #region validation
        private bool IsEmaiValid(string email)
        {
           return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        //TODO: temp logic need for refactoring
        private bool IsAllBoxesFilled
        {
            get
            {
                foreach (var control in this.Controls)
                {
                    if (control.GetType() == typeof(TextBox) && ((TextBox)control).Text == "")
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    #endregion
    }
}
