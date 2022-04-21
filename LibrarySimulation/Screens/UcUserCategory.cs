using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySimulation.Screens
{
    public partial class UcBookCategory : UserControl
    {
        public delegate void RefreshDataFunction();
        public RefreshDataFunction rdf;

        public UcBookCategory()
        {
            InitializeComponent();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            rdf();
        }
    }
}
