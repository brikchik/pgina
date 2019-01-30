using pGina.Plugin.MFLoginPlugin.Entities.Keys;
using pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms;
using pGina.Shared.Settings;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace pGina.Plugin.MFLoginPlugin
{
    public partial class LocalConfiguration : Form
    {
        dynamic m_settings = new pGinaDynamicSettings(MFLoginPlugin.SimpleUuid);

        public LocalConfiguration()
        {
            InitializeComponent();
            this.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void runSetup_button_Click(object sender, EventArgs e)
        {
            FirstRun fr = new FirstRun(true, false);
            this.Close();
        }

        private void newPassword_button_Click(object sender, EventArgs e)
        {
            IKey pk = new PasswordKey();
            pk.AddKey();
        }

        private void newUSB_button_Click(object sender, EventArgs e)
        {
            IKey usbd = new USBDevice();
            usbd.AddKey();
        }

        private void newBluetooth_button_Click(object sender, EventArgs e)
        {
            IKey bk = new BluetoothKey();
            bk.AddKey();
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // !!!!! set language
        }

		private void englishToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// !!!!! set language
		}
        /// <summary>
        /// this code creates the Drag&Drop effect for keys
        /// </summary>
        private int indexOfItemUnderMouseToDrag;
        private Rectangle dragBoxFromMouseDown;
        private Point screenOffset;
        private void DragSource_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            indexOfItemUnderMouseToDrag = ListDragSource.Items.IndexOf(ListDragSource.GetItemAt(e.X, e.Y)); //get element index
            if (indexOfItemUnderMouseToDrag != ListBox.NoMatches)
            {
                Size dragSize = SystemInformation.DragSize;// check if mouse moves far enough
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
                dragBoxFromMouseDown = Rectangle.Empty; // ignore drag if nothing is selected
        }
        private void DragSource_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dragBoxFromMouseDown = Rectangle.Empty;// release cursor on mouse up
        }
        private void DragSource_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // start drag case the cursor is out of source element
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    screenOffset = SystemInformation.WorkingArea.Location;// screenOffset служит для определения границ экрана
                    DragDropEffects dropEffect = ListDragSource.DoDragDrop(ListDragSource.Items[indexOfItemUnderMouseToDrag], DragDropEffects.All);
                }
            }
        }
        private void DragTarget_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            Object item = e.Data.GetData(typeof(System.Windows.Forms.ListViewItem));// check if object is empty
            if (e.Effect == DragDropEffects.Move)
            {
				ListViewItem lvi=(ListViewItem)item;
				string type= lvi.Tag.ToString();
				if (sender == key1Button) key1Button.Text = type;
				if (sender == key2Button) key2Button.Text = type;
				if (sender == key3Button) key3Button.Text = type;
				if (sender == key4Button) key4Button.Text = type;
				if (sender == key5Button) key5Button.Text = type;
				KeySelectionForm ksf = new KeySelectionForm(type);
				((Button)sender).Tag = ksf.Key;
				// Chosen key class (or null) is stored in the TAG field of button.
            }
        }
        private void DragTarget_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            { e.Effect = DragDropEffects.Move; }
            else e.Effect = DragDropEffects.None;
        }
    }
}