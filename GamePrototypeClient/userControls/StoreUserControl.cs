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
                    item.SubItems.Add("asd");
                    item.SubItems.Add(thing.Coins.ToString());
                    ThingsList.Items.Add(item);
                }
            }
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
                    var warehouse = clientService.GetWarehouseById(_character.CharacterWarehouse.Id);
                    clientService.SetThingToCharacter(_things[_chooseIndex], warehouse);
                }
                else
                {
                    MessageBox.Show("Choose thing for buy!!!");
                }
                    
            }
        }
    }
}
