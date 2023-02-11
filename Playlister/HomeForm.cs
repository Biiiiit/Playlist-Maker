using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playlister
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            customizeDesign();
            HideMenuPanels(false);
        }

        public void HideMenuPanels(bool? hide)
        {
            if (hide.HasValue)
            {
                panelMenu.Visible = hide.Value;
                panelMenu.Enabled = hide.Value;
            }
            else
            {
                panelMenu.Visible = !panelMenu.Visible;
                panelMenu.Enabled = !panelMenu.Enabled;
            }
        }
        private void customizeDesign()
        {
            panelSongSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSongSubMenu.Visible == true)
            {
                panelSongSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnSong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSongSubMenu);
        }

        private void btnSideMenu_Click(object sender, EventArgs e)
        {
            HideMenuPanels(null);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            lblTop.Text = childForm.Text.Replace("_", " ");
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            openChildForm(new Add_Song());
        }
    }
}
