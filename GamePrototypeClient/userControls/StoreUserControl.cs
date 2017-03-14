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
using GamePrototypeClient.GamePrototypeServiceReference;

namespace GamePrototypeClient.userControls
{
    public partial class StoreUserControl : UserControl
    {
        private int _chooseIndex = -1;
        private Character _character;
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
                var allThings = clientService.GetAllThings();

                foreach (var thing in allThings)
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
                
            }
        }
    }
}
