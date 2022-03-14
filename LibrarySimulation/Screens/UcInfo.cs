using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySimulation
{
    public partial class UcInfo : UserControl
    {
        public UcInfo()
        {
            InitializeComponent();
        }

        private void picGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ZeyMer1309");
        }
    }
}
