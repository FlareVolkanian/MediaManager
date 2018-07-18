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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Load();
        }

        private void Load()
        {
            App.LoadApplication();
            if (App.AppSettings == null)
            {
                StartWindow startWindow = new StartWindow();
                startWindow.SettingsSaved += (o, e) => LoadData();
                startWindow.Visible = true;
                startWindow.Focus();
            }
            else
            {
                LoadData();
            }
        }

        private void LoadData()
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
