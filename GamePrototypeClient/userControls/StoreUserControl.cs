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
using GamePrototypeClasses.game.thinks;
using GamePrototypeClient.GamePrototypeServiceReference;

namespace GamePrototypeClient.userControls
{
    public partial class StoreUserControl : UserControl
    {
        private int _chooseIndex = -1;
        private Character _character;
        private Things[] _things;
        public StoreUserControl(Character character)
        {
            InitializeComponent();
            InitData();
            BalanceLable.Text = character.Coins.ToString();
            _character = character;
            ThingsList.MultiSelect = false;
        }

        private void InitData()
        {
            using (var clientService = new GamePrototypeServiceClient())
            {
                _things = clientService.GetAllThings();

                foreach (var thing in _things)
                {
                    ListViewItem item = new ListViewItem(thing.Name);
                    item.SubItems.Add(CreateDescription(thing));
                    item.SubItems.Add(thing.Coins.ToString());
                    ThingsList.Items.Add(item);
                }
            }
        }

        private string CreateDescription(Things thing)
        {
            string description = "";
            
            if (thing.Health > 0)
            {
                description += " Health: +" + thing.Health;
            }
            else if (thing.Mana > 0)
            {
                description += " Mana: +" + thing.Mana;
            }
            else if (thing.Defense > 0)
            {
                description += "Defense: +" + thing.Defense;
            }
            else if (thing.Attack > 0)
            {
                description += "Attack: +" + thing.Attack;
            }
            else if (thing.Agility > 0)
            {
                description += "Agility: +" + thing.Agility;
            }
            else if (thing.Intelligence > 0)
            {
                description += "Intelligence: +" + thing.Intelligence;
            }
            else if (thing.MagicAttack > 0)
            {
                description += "MagicAttack: +" + thing.MagicAttack;
            }
            else if (thing.MagicDefence > 0)
            {
                description += "MagicDefence: +" + thing.MagicDefence;
            }
            return description;
        }

        private void BalanceLable_Click(object sender, EventArgs e)
        {

        }

        private void ThingsList_MouseClick(object sender, MouseEventArgs e)
        {
            _chooseIndex = ThingsList.SelectedItems[0].Index;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var newScene = new MainGameScene(_character);
            Parent.Controls.Add(newScene);
            this.Dispose();
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            using (var clientService = new GamePrototypeServiceClient())
            {
                if (_chooseIndex != -1)
                {

                    var newBalance = _character.Coins - _things[_chooseIndex].Coins;
                    _character.Coins = newBalance;
                    var warehouse = clientService.GetWarehouseById(_character.CharacterWarehouse.Id);
                    clientService.SetThingToCharacter(_things[_chooseIndex], warehouse);
                    clientService.UpdateCharacter(_character);
                }
                else
                {
                    MessageBox.Show("Choose thing for buy!!!");
                }
                    
            }
        }
    }
}
