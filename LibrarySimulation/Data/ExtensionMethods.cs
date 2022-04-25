using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySimulation.Data
{
    public static class ExtensionMethods
    {
        public static void SetSelectedWithValue(this ListBox lbx, int value, bool state)
        {
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                dynamic item = lbx.Items[i];
                if (item.ID == value)
                {
                    lbx.SetSelected(i, state);
                    break;
                }
            }
        }
    }
}
