using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePrototypeClient.core;

namespace GamePrototypeClient.gameForms
{
    public partial class AdminWinForm : Form
    {
        public AdminWinForm()
        {
            InitializeComponent();
        }

        private void UpdateItem_Click(object sender, EventArgs e)
        {
            var itemUserControl = new ItemsUserControl();

            //-----------------------------------
            ListViewItem list = new ListViewItem("#0");

            list.SubItems.Add("0");
            list.SubItems.Add("Sword");
            list.SubItems.Add("2");
            list.SubItems.Add("0");
            list.SubItems.Add("0");
            list.SubItems.Add("0");
            list.SubItems.Add("0");
            list.SubItems.Add("0");
            list.SubItems.Add("0");
            list.SubItems.Add("0");
            list.SubItems.Add("0");
            list.SubItems.Add("0");
            list.SubItems.Add("0");
            list.SubItems.Add("0");
            list.SubItems.Add("0");
            //-----------------------------------
            itemUserControl.ItemsList.Items.Add(list);

            this.AdminSplitContainer.Panel2.Controls.Add(itemUserControl);
        }
    }
}
