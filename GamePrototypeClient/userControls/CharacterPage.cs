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
    public partial class CharacterPage : UserControl
    {
        private Character _character;
        public CharacterPage(Character character)
        {
            InitializeComponent();
            Image image = Image.FromFile(character.ImageUrl);
            CharaterImg.Image = image;
            _character = character;

            initData();
        }

        private void initData()
        {
            using (var clientService = new GamePrototypeServiceClient())
            {
                var allCharacterThings = clientService.GetAllCharacterThings(_character);

                foreach (var characterThing in allCharacterThings)
                {
                    var thing = clientService.GetThingById(characterThing.ThingId);
                    var ListViewItem = new ListViewItem(thing.Name);
                    //TODO need add description
                    ListViewItem.SubItems.Add(thing.Defense.ToString());
                    ListViewItem.SubItems.Add(thing.Coins.ToString());
                    WarehouseList.Items.Add(ListViewItem);
                }
            }

            CharacterAgility.Text += _character.Agility.ToString();
            CharacterHealth.Text += _character.Health.ToString();
            CharacterMana.Text += _character.Mana.ToString();
        }

        private void ToMainScene_Click(object sender, EventArgs e)
        {
            var mainGameScene = new MainGameScene(_character);
            Parent.Controls.Add(mainGameScene);
            this.Dispose();
        }
    }
}
