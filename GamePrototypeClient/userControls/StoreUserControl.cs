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
    public partial class StoreUserControl : UserControl
    {
        private int _chooseIndex = -1;
        public StoreUserControl()
        {
            InitializeComponent();
            InitData();
            ThingsList.MultiSelect = false;
        }

        private void InitData()
        {
            using (var clientService = new GamePrototypeServiceClient())
            {
                var allThings = clientService.GetAllThings();

                foreach (var thing in allThings)
                {
                    var listItem = new ListViewItem();
                    listItem.SubItems.

                    ThingsList.Sub.Add(thing);
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

    }
}
