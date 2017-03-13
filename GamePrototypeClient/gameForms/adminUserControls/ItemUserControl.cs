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
                //var allSpecailBonus = clientService.GetAllSpecailBonus
            }
        }
    }
}
