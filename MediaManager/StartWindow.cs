using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTagII
{
    public partial class StartWindow : Form
    {
        private FolderBrowserDialog folderDialog;
        private BindingList<string> Folders;
        private MainWindow Main;

        public event EventHandler SettingsSaved;

        public StartWindow()
        {
            InitializeComponent();
            folderDialog = new FolderBrowserDialog();
            Folders = new BindingList<string>();
            lstFolders.DataSource = Folders;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string dirName = folderDialog.SelectedPath;
                Folders.Add(dirName);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (Folders.Count > 0)
            {
                App.AppSettings = new Settings();
                App.AppSettings.ImageLocations = Folders.ToList();
                App.SaveSettings();
                SettingsSaved?.Invoke(this, EventArgs.Empty);
                Close();
            }
        }
    }
}
