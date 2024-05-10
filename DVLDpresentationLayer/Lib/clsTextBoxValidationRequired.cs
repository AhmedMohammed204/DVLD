using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public static class clsTextBoxValidationRequired
    {
        public static bool IsAllTextBoxesFill(List<TextBox> textBoxList)
        {
            foreach (TextBox txtBox in textBoxList)
            {
                if (string.IsNullOrEmpty(txtBox.Text))
                    return false;
            }

            return true;
        }
    }
}
