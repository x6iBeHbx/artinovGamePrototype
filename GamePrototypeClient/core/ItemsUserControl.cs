using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePrototypeClient.core
{
    public partial class ItemsUserControl : UserControl
    {
        public ItemsUserControl()
        {
            InitializeComponent();

            
        }

        private void ItemsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }
    }
}
