using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePrototypeClasses.core;
using GamePrototypeClasses.enums;
using GamePrototypeClasses.game.thinks;
using GamePrototypeClient.GamePrototypeServiceReference;

namespace GamePrototypeClient.gameForms.adminUserControls
{
    public partial class ItemUserControl : UserControl
    {
        public ItemUserControl()
        {
            InitializeComponent();
            FillThingTypeComboBox();
        }

        public ItemUserControl(ThingEntity thing)
        {
            InitializeComponent();
            FillThingTypeComboBox(Enum.GetName(typeof(ThingsTypeEnum), thing.ThingsType));
        }

        private void FillSpecailBonusList()
        {
            using (var clientService = new GamePrototypeServiceClient())
            {
                //var allSpecailBonus = clientService.GetAllSpecailBonus
            }
        }

        private void FillThingTypeComboBox(string defaultName = null)
        {
            if (defaultName != null)
            {
                this.ThingTypeComboBox.Text = defaultName;
            }

            foreach (var name in Enum.GetNames(typeof(ThingsTypeEnum)))
            {
                this.ThingTypeComboBox.Items.Add(name);
            }
        }

        private void UpdateItemBtn_Click(object sender, EventArgs e)
        {
            using (var clientService = new GamePrototypeServiceClient())
            {
                var thing = new Things();
                thing.Name = NameTextBox.Text;
                thing.Level = Int32.Parse(LevelTextBox.Text);
                thing.Health = Int32.Parse(HealthTextBox.Text);
                thing.Mana = Int32.Parse(ManaTextBox.Text);
                thing.Attack = Int32.Parse(AttackTextBox.Text);
                thing.MagicAttack = Int32.Parse(MagicAttackTextBox.Text);
                thing.Defense = Int32.Parse(DefenceTextBox.Text);
                thing.MagicDefence = Int32.Parse(MagicDefenceTextBox.Text);
                thing.Agility = Int32.Parse(AgilityTextBox.Text);
                thing.Intelligence = Int32.Parse(IntelligenceTextBox.Text);
                thing.Coins = Int32.Parse(CoinsBox.Text);
                thing.ImageUrl = ImageBox.ImageLocation;

                thing.ThingsType = (ThingsTypeEnum) Enum.Parse(typeof(ThingsTypeEnum), ThingTypeComboBox.SelectedItem.ToString()) ;

                thing.SpecialThingBonus = null;

                clientService.SetThing(thing);
            }
        }

        private void LoadImgBtn_Click(object sender, EventArgs e)
        {
            using (var loadDialog = new OpenFileDialog())
            {
                loadDialog.ShowDialog();
                Bitmap img = (Bitmap)Image.FromFile(loadDialog.FileName);
                ImageBox.Image = img;
                ImageBox.ImageLocation = loadDialog.FileName;
            }
        }
    }
}
