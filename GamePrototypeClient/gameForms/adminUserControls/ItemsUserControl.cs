using System.Windows.Forms;

namespace GamePrototypeClient.gameForms.adminUserControls
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
